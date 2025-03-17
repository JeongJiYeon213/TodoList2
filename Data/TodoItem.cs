using System;

namespace TodoList2.Models
{
    public class TodoItem
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Memo { get; set; }
        public bool IsDone { get; set; }
        public string ImageUrl { get; set; } // ✅ 이미지 URL 추가
    }
}
