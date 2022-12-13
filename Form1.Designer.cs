namespace TodoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewTask = new System.Windows.Forms.Button();
            this.TodoListDisplay = new System.Windows.Forms.RichTextBox();
            this.TodoTaskContent = new System.Windows.Forms.TextBox();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.TodoListItemReply = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewTask
            // 
            this.btnViewTask.Location = new System.Drawing.Point(21, 427);
            this.btnViewTask.Name = "btnViewTask";
            this.btnViewTask.Size = new System.Drawing.Size(94, 29);
            this.btnViewTask.TabIndex = 0;
            this.btnViewTask.Text = "View Task";
            this.btnViewTask.UseVisualStyleBackColor = true;
            this.btnViewTask.Click += new System.EventHandler(this.View_Task_Click);
            // 
            // TodoListDisplay
            // 
            this.TodoListDisplay.Location = new System.Drawing.Point(21, 47);
            this.TodoListDisplay.Name = "TodoListDisplay";
            this.TodoListDisplay.Size = new System.Drawing.Size(371, 352);
            this.TodoListDisplay.TabIndex = 1;
            this.TodoListDisplay.Text = "";
            this.TodoListDisplay.TextChanged += new System.EventHandler(this.TodoList_TextChanged);
            // 
            // TodoTaskContent
            // 
            this.TodoTaskContent.Location = new System.Drawing.Point(410, 80);
            this.TodoTaskContent.Name = "TodoTaskContent";
            this.TodoTaskContent.PlaceholderText = "Enter your todo task";
            this.TodoTaskContent.Size = new System.Drawing.Size(315, 27);
            this.TodoTaskContent.TabIndex = 2;
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(244, 427);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(148, 29);
            this.btnRemoveTask.TabIndex = 3;
            this.btnRemoveTask.Text = "Remove Task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.Remove_task_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add New Task";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(631, 143);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(94, 29);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.Add_Task_Click);
            // 
            // TodoListItemReply
            // 
            this.TodoListItemReply.AutoSize = true;
            this.TodoListItemReply.Location = new System.Drawing.Point(398, 152);
            this.TodoListItemReply.Name = "TodoListItemReply";
            this.TodoListItemReply.Size = new System.Drawing.Size(0, 20);
            this.TodoListItemReply.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 638);
            this.Controls.Add(this.TodoListItemReply);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.TodoTaskContent);
            this.Controls.Add(this.TodoListDisplay);
            this.Controls.Add(this.btnViewTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewTask;
        private System.Windows.Forms.RichTextBox TodoListDisplay;
        private System.Windows.Forms.TextBox TodoTaskContent;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label TodoListItemReply;
    }
}
