using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using TodoList2.Models;

namespace TodoList2.Data
{
    public class DataManager
    {
        private static string filePath = "data.json";

        public static void SaveData(List<TodoItem> todoList)
        {
            string json = JsonConvert.SerializeObject(todoList, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static List<TodoItem> LoadData()
        {
            if (!File.Exists(filePath)) return new List<TodoItem>();
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<TodoItem>>(json);
        }
    }
}
