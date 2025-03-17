using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TodoList2.Data;
using TodoList2.Models;

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



        // ✅ 신규 버튼 (새 창 열기)
        private void btnNew_Click(object sender, EventArgs e)
        {
            var formNewTodo = new FormNewTodo();
            if (formNewTodo.ShowDialog() == DialogResult.OK)
            {
                todoList.Add(formNewTodo.NewTodo);
                DataManager.SaveData(todoList);  // 데이터 저장
                LoadTodoList();  // 목록 새로 고침
            }
        }

        // ✅ 수정 버튼
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
            selectedTodo.ImageUrl = pictureBoxImage.ImageLocation ?? null;

            DataManager.SaveData(todoList);  // 데이터 저장
            LoadTodoList();  // 목록 새로 고침
        }

        // ✅ 삭제 버튼
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewTodo.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIndex = listViewTodo.SelectedItems[0].Index;
            todoList.RemoveAt(selectedIndex);

            pictureBoxImage.Image = null; // 선택 항목 삭제 시 이미지 초기화
            DataManager.SaveData(todoList);  // 데이터 저장
            LoadTodoList();  // 목록 새로 고침
        }

        // ✅ 체크박스 상태 변경 시 저장
        private void listViewTodo_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (isLoading) return;

            var index = e.Item.Index;
            if (index >= 0 && index < todoList.Count)
            {
                todoList[index].IsDone = e.Item.Checked;
                DataManager.SaveData(todoList);  // 데이터 저장
                UpdateStatusBar();
            }
        }

        // ✅ 할 일 목록 로드
        private void LoadTodoList(bool isFiltered = false)
        {
            isLoading = true;

            listViewTodo.Items.Clear();
            listViewTodo.CheckBoxes = true;
            listViewTodo.Columns.Clear();

            listViewTodo.Columns.Add("상태", 50);
            listViewTodo.Columns.Add("날짜", 100);
            listViewTodo.Columns.Add("할 일", 200);
            listViewTodo.Columns.Add("메모", 250);
            listViewTodo.FullRowSelect = true;

            var list = isFiltered
                ? todoList.Where(todo => todo.Date.Date == dateTimePicker.Value.Date)
                : todoList;

            foreach (var todo in list)
            {
                var item = new ListViewItem();
                item.Checked = todo.IsDone;
                item.SubItems.Add(todo.Date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(todo.Title);
                item.SubItems.Add(todo.Memo);
                listViewTodo.Items.Add(item);
            }

            isLoading = false;
            UpdateStatusBar();
        }

        // ✅ 상태 바 업데이트
        private void UpdateStatusBar()
        {
            int completeCount = listViewTodo.Items.Cast<ListViewItem>().Count(item => item.Checked);
            int totalCount = listViewTodo.Items.Count;

            toolStripStatusLabelComplete.Text = $"완료: {completeCount}";
            toolStripStatusLabelIncomplete.Text = $"미완료: {totalCount - completeCount}";
            toolStripStatusLabelTotal.Text = $"전체: {totalCount}";
        }

        // ✅ 리스트에서 항목 선택 시 데이터 채우기
        private void listViewTodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTodo.SelectedItems.Count == 0) return;

            var selectedIndex = listViewTodo.SelectedItems[0].Index;
            if (selectedIndex >= 0 && selectedIndex < todoList.Count)
            {
                var selectedTodo = todoList[selectedIndex];

                dateTimePicker.Value = selectedTodo.Date;
                txtTodo.Text = selectedTodo.Title;
                richTextBoxMemo.Text = selectedTodo.Memo;
                listViewTodo.Items[selectedIndex].Checked = selectedTodo.IsDone;

                // ✅ 이미지 로드
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
    }
}
