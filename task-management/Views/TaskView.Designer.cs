namespace task_management.Views
{
    partial class TaskView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskTabControl = new System.Windows.Forms.TabControl();
            this.taskListTabPage = new System.Windows.Forms.TabPage();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.addNewTaskButton = new System.Windows.Forms.Button();
            this.taskDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTaskButton = new System.Windows.Forms.Button();
            this.taskSearchTextBox = new System.Windows.Forms.TextBox();
            this.taskSearchLabel = new System.Windows.Forms.Label();
            this.taskDetailTabPage = new System.Windows.Forms.TabPage();
            this.dueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.taskProjectIDTextBox = new System.Windows.Forms.TextBox();
            this.taskProjectIDLabel = new System.Windows.Forms.Label();
            this.taskStatusTextBox = new System.Windows.Forms.TextBox();
            this.taskStatusLabel = new System.Windows.Forms.Label();
            this.taskPriorityTextBox = new System.Windows.Forms.TextBox();
            this.taskPriorityLabel = new System.Windows.Forms.Label();
            this.taskDueDateLabel = new System.Windows.Forms.Label();
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.taskDescriptionLabel = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskCancelButton = new System.Windows.Forms.Button();
            this.taskSaveButton = new System.Windows.Forms.Button();
            this.taskIDTextBox = new System.Windows.Forms.TextBox();
            this.taskIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.taskTabControl.SuspendLayout();
            this.taskListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).BeginInit();
            this.taskDetailTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.Location = new System.Drawing.Point(45, 24);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(71, 25);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Tasks";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.taskLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 72);
            this.panel1.TabIndex = 1;
            // 
            // taskTabControl
            // 
            this.taskTabControl.Controls.Add(this.taskListTabPage);
            this.taskTabControl.Controls.Add(this.taskDetailTabPage);
            this.taskTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskTabControl.Location = new System.Drawing.Point(0, 72);
            this.taskTabControl.Name = "taskTabControl";
            this.taskTabControl.SelectedIndex = 0;
            this.taskTabControl.Size = new System.Drawing.Size(850, 473);
            this.taskTabControl.TabIndex = 2;
            // 
            // taskListTabPage
            // 
            this.taskListTabPage.Controls.Add(this.deleteTaskButton);
            this.taskListTabPage.Controls.Add(this.editTaskButton);
            this.taskListTabPage.Controls.Add(this.addNewTaskButton);
            this.taskListTabPage.Controls.Add(this.taskDataGridView);
            this.taskListTabPage.Controls.Add(this.searchTaskButton);
            this.taskListTabPage.Controls.Add(this.taskSearchTextBox);
            this.taskListTabPage.Controls.Add(this.taskSearchLabel);
            this.taskListTabPage.Location = new System.Drawing.Point(4, 29);
            this.taskListTabPage.Name = "taskListTabPage";
            this.taskListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.taskListTabPage.Size = new System.Drawing.Size(842, 440);
            this.taskListTabPage.TabIndex = 0;
            this.taskListTabPage.Text = "Task list";
            this.taskListTabPage.UseVisualStyleBackColor = true;
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTaskButton.Location = new System.Drawing.Point(703, 218);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(108, 26);
            this.deleteTaskButton.TabIndex = 7;
            this.deleteTaskButton.Text = "Delete";
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            // 
            // editTaskButton
            // 
            this.editTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTaskButton.Location = new System.Drawing.Point(703, 168);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(108, 26);
            this.editTaskButton.TabIndex = 6;
            this.editTaskButton.Text = "Edit";
            this.editTaskButton.UseVisualStyleBackColor = true;
            // 
            // addNewTaskButton
            // 
            this.addNewTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewTaskButton.Location = new System.Drawing.Point(703, 119);
            this.addNewTaskButton.Name = "addNewTaskButton";
            this.addNewTaskButton.Size = new System.Drawing.Size(108, 26);
            this.addNewTaskButton.TabIndex = 5;
            this.addNewTaskButton.Text = "Add new";
            this.addNewTaskButton.UseVisualStyleBackColor = true;
            // 
            // taskDataGridView
            // 
            this.taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDataGridView.Location = new System.Drawing.Point(18, 119);
            this.taskDataGridView.Name = "taskDataGridView";
            this.taskDataGridView.Size = new System.Drawing.Size(651, 302);
            this.taskDataGridView.TabIndex = 4;
            // 
            // searchTaskButton
            // 
            this.searchTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTaskButton.Location = new System.Drawing.Point(561, 65);
            this.searchTaskButton.Name = "searchTaskButton";
            this.searchTaskButton.Size = new System.Drawing.Size(108, 26);
            this.searchTaskButton.TabIndex = 4;
            this.searchTaskButton.Text = "Search";
            this.searchTaskButton.UseVisualStyleBackColor = true;
            // 
            // taskSearchTextBox
            // 
            this.taskSearchTextBox.Location = new System.Drawing.Point(18, 65);
            this.taskSearchTextBox.Name = "taskSearchTextBox";
            this.taskSearchTextBox.Size = new System.Drawing.Size(527, 26);
            this.taskSearchTextBox.TabIndex = 3;
            // 
            // taskSearchLabel
            // 
            this.taskSearchLabel.AutoSize = true;
            this.taskSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskSearchLabel.Location = new System.Drawing.Point(14, 31);
            this.taskSearchLabel.Name = "taskSearchLabel";
            this.taskSearchLabel.Size = new System.Drawing.Size(98, 20);
            this.taskSearchLabel.TabIndex = 1;
            this.taskSearchLabel.Text = "Search task:";
            // 
            // taskDetailTabPage
            // 
            this.taskDetailTabPage.Controls.Add(this.dueDateTimePicker);
            this.taskDetailTabPage.Controls.Add(this.taskProjectIDTextBox);
            this.taskDetailTabPage.Controls.Add(this.taskProjectIDLabel);
            this.taskDetailTabPage.Controls.Add(this.taskStatusTextBox);
            this.taskDetailTabPage.Controls.Add(this.taskStatusLabel);
            this.taskDetailTabPage.Controls.Add(this.taskPriorityTextBox);
            this.taskDetailTabPage.Controls.Add(this.taskPriorityLabel);
            this.taskDetailTabPage.Controls.Add(this.taskDueDateLabel);
            this.taskDetailTabPage.Controls.Add(this.taskDescriptionTextBox);
            this.taskDetailTabPage.Controls.Add(this.taskDescriptionLabel);
            this.taskDetailTabPage.Controls.Add(this.taskNameTextBox);
            this.taskDetailTabPage.Controls.Add(this.taskNameLabel);
            this.taskDetailTabPage.Controls.Add(this.taskCancelButton);
            this.taskDetailTabPage.Controls.Add(this.taskSaveButton);
            this.taskDetailTabPage.Controls.Add(this.taskIDTextBox);
            this.taskDetailTabPage.Controls.Add(this.taskIDLabel);
            this.taskDetailTabPage.Location = new System.Drawing.Point(4, 29);
            this.taskDetailTabPage.Name = "taskDetailTabPage";
            this.taskDetailTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.taskDetailTabPage.Size = new System.Drawing.Size(842, 440);
            this.taskDetailTabPage.TabIndex = 1;
            this.taskDetailTabPage.Text = "Task detail";
            this.taskDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // dueDateTimePicker
            // 
            this.dueDateTimePicker.Location = new System.Drawing.Point(498, 174);
            this.dueDateTimePicker.Name = "dueDateTimePicker";
            this.dueDateTimePicker.Size = new System.Drawing.Size(191, 26);
            this.dueDateTimePicker.TabIndex = 8;
            this.dueDateTimePicker.Value = new System.DateTime(2023, 5, 28, 12, 0, 0, 0);
            // 
            // taskProjectIDTextBox
            // 
            this.taskProjectIDTextBox.Location = new System.Drawing.Point(498, 275);
            this.taskProjectIDTextBox.Name = "taskProjectIDTextBox";
            this.taskProjectIDTextBox.Size = new System.Drawing.Size(191, 26);
            this.taskProjectIDTextBox.TabIndex = 11;
            // 
            // taskProjectIDLabel
            // 
            this.taskProjectIDLabel.AutoSize = true;
            this.taskProjectIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskProjectIDLabel.Location = new System.Drawing.Point(494, 241);
            this.taskProjectIDLabel.Name = "taskProjectIDLabel";
            this.taskProjectIDLabel.Size = new System.Drawing.Size(83, 20);
            this.taskProjectIDLabel.TabIndex = 18;
            this.taskProjectIDLabel.Text = "Project ID:";
            // 
            // taskStatusTextBox
            // 
            this.taskStatusTextBox.Location = new System.Drawing.Point(268, 275);
            this.taskStatusTextBox.Name = "taskStatusTextBox";
            this.taskStatusTextBox.Size = new System.Drawing.Size(191, 26);
            this.taskStatusTextBox.TabIndex = 10;
            // 
            // taskStatusLabel
            // 
            this.taskStatusLabel.AutoSize = true;
            this.taskStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskStatusLabel.Location = new System.Drawing.Point(222, 241);
            this.taskStatusLabel.Name = "taskStatusLabel";
            this.taskStatusLabel.Size = new System.Drawing.Size(60, 20);
            this.taskStatusLabel.TabIndex = 16;
            this.taskStatusLabel.Text = "Status:";
            // 
            // taskPriorityTextBox
            // 
            this.taskPriorityTextBox.Location = new System.Drawing.Point(34, 275);
            this.taskPriorityTextBox.Name = "taskPriorityTextBox";
            this.taskPriorityTextBox.Size = new System.Drawing.Size(191, 26);
            this.taskPriorityTextBox.TabIndex = 9;
            // 
            // taskPriorityLabel
            // 
            this.taskPriorityLabel.AutoSize = true;
            this.taskPriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskPriorityLabel.Location = new System.Drawing.Point(30, 241);
            this.taskPriorityLabel.Name = "taskPriorityLabel";
            this.taskPriorityLabel.Size = new System.Drawing.Size(60, 20);
            this.taskPriorityLabel.TabIndex = 14;
            this.taskPriorityLabel.Text = "Priority:";
            // 
            // taskDueDateLabel
            // 
            this.taskDueDateLabel.AutoSize = true;
            this.taskDueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDueDateLabel.Location = new System.Drawing.Point(494, 140);
            this.taskDueDateLabel.Name = "taskDueDateLabel";
            this.taskDueDateLabel.Size = new System.Drawing.Size(79, 20);
            this.taskDueDateLabel.TabIndex = 12;
            this.taskDueDateLabel.Text = "Due date:";
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(268, 174);
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(191, 26);
            this.taskDescriptionTextBox.TabIndex = 7;
            // 
            // taskDescriptionLabel
            // 
            this.taskDescriptionLabel.AutoSize = true;
            this.taskDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescriptionLabel.Location = new System.Drawing.Point(264, 140);
            this.taskDescriptionLabel.Name = "taskDescriptionLabel";
            this.taskDescriptionLabel.Size = new System.Drawing.Size(128, 20);
            this.taskDescriptionLabel.TabIndex = 10;
            this.taskDescriptionLabel.Text = "Task description:";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(34, 174);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(191, 26);
            this.taskNameTextBox.TabIndex = 6;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLabel.Location = new System.Drawing.Point(30, 140);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(91, 20);
            this.taskNameLabel.TabIndex = 8;
            this.taskNameLabel.Text = "Task name:";
            // 
            // taskCancelButton
            // 
            this.taskCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskCancelButton.Location = new System.Drawing.Point(362, 373);
            this.taskCancelButton.Name = "taskCancelButton";
            this.taskCancelButton.Size = new System.Drawing.Size(169, 39);
            this.taskCancelButton.TabIndex = 13;
            this.taskCancelButton.Text = "Cancel";
            this.taskCancelButton.UseVisualStyleBackColor = true;
            // 
            // taskSaveButton
            // 
            this.taskSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskSaveButton.Location = new System.Drawing.Point(166, 373);
            this.taskSaveButton.Name = "taskSaveButton";
            this.taskSaveButton.Size = new System.Drawing.Size(169, 39);
            this.taskSaveButton.TabIndex = 12;
            this.taskSaveButton.Text = "Save";
            this.taskSaveButton.UseVisualStyleBackColor = true;
            // 
            // taskIDTextBox
            // 
            this.taskIDTextBox.Location = new System.Drawing.Point(34, 77);
            this.taskIDTextBox.Name = "taskIDTextBox";
            this.taskIDTextBox.Size = new System.Drawing.Size(191, 26);
            this.taskIDTextBox.TabIndex = 5;
            // 
            // taskIDLabel
            // 
            this.taskIDLabel.AutoSize = true;
            this.taskIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskIDLabel.Location = new System.Drawing.Point(30, 44);
            this.taskIDLabel.Name = "taskIDLabel";
            this.taskIDLabel.Size = new System.Drawing.Size(68, 20);
            this.taskIDLabel.TabIndex = 4;
            this.taskIDLabel.Text = "Task ID:";
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 545);
            this.Controls.Add(this.taskTabControl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaskView";
            this.Text = "TaskView";
            this.Load += new System.EventHandler(this.TaskView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.taskTabControl.ResumeLayout(false);
            this.taskListTabPage.ResumeLayout(false);
            this.taskListTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).EndInit();
            this.taskDetailTabPage.ResumeLayout(false);
            this.taskDetailTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl taskTabControl;
        private System.Windows.Forms.TabPage taskListTabPage;
        private System.Windows.Forms.TabPage taskDetailTabPage;
        private System.Windows.Forms.Label taskSearchLabel;
        private System.Windows.Forms.DataGridView taskDataGridView;
        private System.Windows.Forms.Button searchTaskButton;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.Button addNewTaskButton;
        private System.Windows.Forms.Button taskSaveButton;
        private System.Windows.Forms.TextBox taskIDTextBox;
        private System.Windows.Forms.Label taskIDLabel;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Button taskCancelButton;
        private System.Windows.Forms.TextBox taskDescriptionTextBox;
        private System.Windows.Forms.Label taskDescriptionLabel;
        private System.Windows.Forms.TextBox taskPriorityTextBox;
        private System.Windows.Forms.Label taskPriorityLabel;
        private System.Windows.Forms.Label taskDueDateLabel;
        private System.Windows.Forms.TextBox taskProjectIDTextBox;
        private System.Windows.Forms.Label taskProjectIDLabel;
        private System.Windows.Forms.TextBox taskStatusTextBox;
        private System.Windows.Forms.Label taskStatusLabel;
        private System.Windows.Forms.DateTimePicker dueDateTimePicker;
        private System.Windows.Forms.TextBox taskSearchTextBox;
    }
}