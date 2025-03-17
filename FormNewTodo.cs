using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using TodoList2.Models;

namespace TodoList2
{
    public partial class FormNewTodo : Form
    {
        private const string NAVER_CLIENT_ID = "UeLcKSxvOOLId3jXMAct";
        private const string NAVER_CLIENT_SECRET = "ycgoxQ1f5o";
        private const string IMAGE_SEARCH_URL = "https://openapi.naver.com/v1/search/image?query=";

        public TodoItem NewTodo { get; private set; }

        public FormNewTodo()
        {
            InitializeComponent();
        }

        // ✅ 저장 버튼 클릭
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTodoInput.Text))
            {
                MessageBox.Show("할 일을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewTodo = new TodoItem
            {
                Date = dateTimePicker1.Value,
                Title = txtTodoInput.Text,
                Memo = richTextBoxMemoInput.Text,
                IsDone = false,
                ImageUrl = pictureBoxTodoImage.ImageLocation
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        // ✅ 이미지 검색 버튼 클릭
        private async void btnSearchImage_Click(object sender, EventArgs e)
        {
            string query = txtSearchImage.Text;
            if (string.IsNullOrWhiteSpace(query)) return;

            string url = $"{IMAGE_SEARCH_URL}{Uri.EscapeDataString(query)}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Naver-Client-Id", NAVER_CLIENT_ID);
                client.DefaultRequestHeaders.Add("X-Naver-Client-Secret", NAVER_CLIENT_SECRET);

                try
                {
                    var response = await client.GetStringAsync(url);
                    var json = JObject.Parse(response);
                    var imageUrl = json["items"]?[0]?["thumbnail"]?.ToString();

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        pictureBoxTodoImage.Load(imageUrl);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"오류 발생: {ex.Message}");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

     
    }
}
