using TodoList2.Models;
using TodoList2.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace TodoList2
{
    public partial class Form1 : Form
    {
        private List<TodoItem> todoList;
        private bool isLoading = false;

        public Form1()
        {
            InitializeComponent();
            todoList = DataManager.LoadData();
            LoadTodoList();

            UpdateStatusBar();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTodo.Text))
            {
                MessageBox.Show("할 일을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newTodo = new TodoItem
            {
                Date = dateTimePicker.Value,
                Title = txtTodo.Text,
                Memo = richTextBoxMemo.Text,
                IsDone = false,
                ImageUrl = pictureBoxImage.ImageLocation
            };

            todoList.Add(newTodo);
            DataManager.SaveData(todoList);
            LoadTodoList();
            ClearInput();

            UpdateStatusBar();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (listViewTodo.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIndex = listViewTodo.SelectedItems[0].Index;
            var selectedTodo = todoList[selectedIndex];

            selectedTodo.Date = dateTimePicker.Value;
            selectedTodo.Title = txtTodo.Text;
            selectedTodo.Memo = richTextBoxMemo.Text;
            selectedTodo.IsDone = listViewTodo.Items[selectedIndex].Checked;
            selectedTodo.ImageUrl = pictureBoxImage.ImageLocation;

            DataManager.SaveData(todoList);
            LoadTodoList();
            ClearInput();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewTodo.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIndex = listViewTodo.SelectedItems[0].Index;
            todoList.RemoveAt(selectedIndex);

            DataManager.SaveData(todoList);
            LoadTodoList();
            ClearInput();
        }

        private void LoadTodoList()
        {
            isLoading = true;

            listViewTodo.Items.Clear();
            listViewTodo.Columns.Clear();

            listViewTodo.CheckBoxes = true;
            listViewTodo.Columns.Add("완료", 50);
            listViewTodo.Columns.Add("날짜", 100);
            listViewTodo.Columns.Add("할 일", 200);
            listViewTodo.Columns.Add("메모", 250);
            listViewTodo.FullRowSelect = true;

            foreach (var todo in todoList)
            {
                var item = new ListViewItem
                {
                    Checked = todo.IsDone
                };

                item.SubItems.Add(todo.Date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(todo.Title);
                item.SubItems.Add(todo.Memo);

                listViewTodo.Items.Add(item);
            }

            isLoading = false;

            UpdateStatusBar();
        }

        private void ClearInput()
        {
            dateTimePicker.Value = DateTime.Now;
            txtTodo.Clear();
            richTextBoxMemo.Clear();
            pictureBoxImage.Image = null;
        }

        private void listViewTodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTodo.SelectedItems.Count > 0)
            {
                var selectedIndex = listViewTodo.SelectedItems[0].Index;
                var selectedTodo = todoList[selectedIndex];

                dateTimePicker.Value = selectedTodo.Date;
                txtTodo.Text = selectedTodo.Title;
                richTextBoxMemo.Text = selectedTodo.Memo;

                if (!string.IsNullOrEmpty(selectedTodo.ImageUrl))
                {
                    pictureBoxImage.Load(selectedTodo.ImageUrl);
                }
                else
                {
                    pictureBoxImage.Image = null;
                }
            }
        }

        private void listViewTodo_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (isLoading) return;

            var currentIndex = e.Item.Index;
            if (currentIndex < 0 || currentIndex >= todoList.Count) return;

            todoList[currentIndex].IsDone = e.Item.Checked;
        }

        private async void btnSearchImage_Click(object sender, EventArgs e)
        {
            string query = txtSearchImage.Text;
            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("검색어를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string url = $"https://openapi.naver.com/v1/search/image?query={Uri.EscapeDataString(query)}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Naver-Client-Id", "UeLcKSxvOOLId3jXMAct");
                client.DefaultRequestHeaders.Add("X-Naver-Client-Secret", "ycgoxQ1f5o");

                try
                {
                    var response = await client.GetStringAsync(url);
                    var json = JObject.Parse(response);
                    var imageUrl = json["items"]?[0]?["thumbnail"]?.ToString();

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        pictureBoxImage.Load(imageUrl);
                    }
                    else
                    {
                        MessageBox.Show("이미지를 찾을 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"오류 발생: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateStatusBar()
        {
            int completeCount = listViewTodo.Items.Cast<ListViewItem>().Count(item => item.Checked);
            int totalCount = listViewTodo.Items.Count;
            int incompleteCount = totalCount - completeCount;

            toolStripStatusLabelComplete.Text = $"완료: {completeCount}";
            toolStripStatusLabelIncomplete.Text = $"미완료: {incompleteCount}";
            toolStripStatusLabelTotal.Text = $"전체: {totalCount}";
        }

    }
}
