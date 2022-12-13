using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class Form1 : Form
    {
        readonly string _path = "C:\\Learning-Paths\\C#DotNet\\Training_class\\Task\\Todo.txt";
        //readonly string _path = Path.Combine("C:\\Learning-Paths\\C#DotNet\\Training_class\\Task\\TodoApp", "Todo.txt"); 
        private List<string> _todoListTask = new List<string>();
        TodoList todoList = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Task_Click(object sender, System.EventArgs e)
        {
            _todoListTask.Add(TodoTaskContent.Text);
            todoList.WriteTodoList(_path, _todoListTask);
            TodoListDisplay.Text = string.Join("\n", _todoListTask);
            if(TodoTaskContent.Text != string.Empty)
            {
                TodoListItemReply.Text = "Task Added";
            }
            else
            {
                TodoListItemReply.Text = "Failed to Add Task";
            }
        }
        private void Remove_task_Click(object sender, System.EventArgs e)
        {
            foreach (var item in _todoListTask)
            {
                TodoListItemReply.Text = item;
                _todoListTask.Remove(TodoTaskContent.Text = item);
                todoList.RemoveTodoList(_path, _todoListTask);
            }

        }

        private void View_Task_Click(object sender, System.EventArgs e)
        {
            TodoListDisplay.Text = todoList.ViewTodoList(_path);
        }

        private void TodoList_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
