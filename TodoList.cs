using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoList
    {
        public bool WriteTodoList(string filePath, List<string> todoListContent)
        {
            try
            {

            File.AppendAllLines(filePath, todoListContent);
            return true;
            }
            catch
            {
                return false;
            }
        }
        public string ViewTodoList(string filepath)
        {
            try
            {
                return File.ReadAllText(filepath);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string RemoveTodoList(string filePath, List<string> TodoListContent)
        {
            File.Delete(filePath);
            return filePath;
        }
      
    }
}
