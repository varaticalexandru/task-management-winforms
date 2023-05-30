namespace task_management.Views
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tasksTabPage = new System.Windows.Forms.TabPage();
            this.deleteTaskButton = new MaterialSkin.Controls.MaterialButton();
            this.editTaskButton = new MaterialSkin.Controls.MaterialButton();
            this.addNewTaskButton = new MaterialSkin.Controls.MaterialButton();
            this.searchTaskButton = new MaterialSkin.Controls.MaterialButton();
            this.taskSearchTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.taskSearchLabel = new MaterialSkin.Controls.MaterialLabel();
            this.taskDataGridView = new System.Windows.Forms.DataGridView();
            this.addEditTaskTabPage = new System.Windows.Forms.TabPage();
            this.taskCancelButton = new MaterialSkin.Controls.MaterialButton();
            this.taskSaveButton = new MaterialSkin.Controls.MaterialButton();
            this.taskProjectIDLabel = new MaterialSkin.Controls.MaterialLabel();
            this.taskProjectIDTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.taskStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.taskStatusTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.taskPriorityLabel = new MaterialSkin.Controls.MaterialLabel();
            this.taskPriorityTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.dueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.taskDueDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.taskDescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.taskDescriptionTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.taskNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.taskNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.taskIDLabel = new MaterialSkin.Controls.MaterialLabel();
            this.taskIDTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.projectsTabPage = new System.Windows.Forms.TabPage();
            this.projectsDataGridView = new System.Windows.Forms.DataGridView();
            this.taskAssignmentsTabPage = new System.Windows.Forms.TabPage();
            this.commentsTabPage = new System.Windows.Forms.TabPage();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.logoutTabPage = new System.Windows.Forms.TabPage();
            this.exitTabPage = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.tasksTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).BeginInit();
            this.addEditTaskTabPage.SuspendLayout();
            this.projectsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tasksTabPage);
            this.materialTabControl1.Controls.Add(this.addEditTaskTabPage);
            this.materialTabControl1.Controls.Add(this.projectsTabPage);
            this.materialTabControl1.Controls.Add(this.taskAssignmentsTabPage);
            this.materialTabControl1.Controls.Add(this.commentsTabPage);
            this.materialTabControl1.Controls.Add(this.usersTabPage);
            this.materialTabControl1.Controls.Add(this.settingsTabPage);
            this.materialTabControl1.Controls.Add(this.logoutTabPage);
            this.materialTabControl1.Controls.Add(this.exitTabPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1194, 733);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tasksTabPage
            // 
            this.tasksTabPage.Controls.Add(this.deleteTaskButton);
            this.tasksTabPage.Controls.Add(this.editTaskButton);
            this.tasksTabPage.Controls.Add(this.addNewTaskButton);
            this.tasksTabPage.Controls.Add(this.searchTaskButton);
            this.tasksTabPage.Controls.Add(this.taskSearchTextBox);
            this.tasksTabPage.Controls.Add(this.taskSearchLabel);
            this.tasksTabPage.Controls.Add(this.taskDataGridView);
            this.tasksTabPage.ImageKey = "tasks.png";
            this.tasksTabPage.Location = new System.Drawing.Point(4, 39);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tasksTabPage.Size = new System.Drawing.Size(1186, 690);
            this.tasksTabPage.TabIndex = 0;
            this.tasksTabPage.Text = "Tasks";
            this.tasksTabPage.UseVisualStyleBackColor = true;
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.AutoSize = false;
            this.deleteTaskButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteTaskButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteTaskButton.Depth = 0;
            this.deleteTaskButton.HighEmphasis = true;
            this.deleteTaskButton.Icon = null;
            this.deleteTaskButton.Location = new System.Drawing.Point(933, 284);
            this.deleteTaskButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteTaskButton.Size = new System.Drawing.Size(155, 36);
            this.deleteTaskButton.TabIndex = 20;
            this.deleteTaskButton.Text = "Delete";
            this.deleteTaskButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteTaskButton.UseAccentColor = false;
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            // 
            // editTaskButton
            // 
            this.editTaskButton.AutoSize = false;
            this.editTaskButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editTaskButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editTaskButton.Depth = 0;
            this.editTaskButton.HighEmphasis = true;
            this.editTaskButton.Icon = null;
            this.editTaskButton.Location = new System.Drawing.Point(933, 213);
            this.editTaskButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editTaskButton.Size = new System.Drawing.Size(155, 36);
            this.editTaskButton.TabIndex = 19;
            this.editTaskButton.Text = "Edit";
            this.editTaskButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editTaskButton.UseAccentColor = false;
            this.editTaskButton.UseVisualStyleBackColor = true;
            // 
            // addNewTaskButton
            // 
            this.addNewTaskButton.AutoSize = false;
            this.addNewTaskButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addNewTaskButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addNewTaskButton.Depth = 0;
            this.addNewTaskButton.HighEmphasis = true;
            this.addNewTaskButton.Icon = null;
            this.addNewTaskButton.Location = new System.Drawing.Point(933, 145);
            this.addNewTaskButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addNewTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addNewTaskButton.Name = "addNewTaskButton";
            this.addNewTaskButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addNewTaskButton.Size = new System.Drawing.Size(155, 36);
            this.addNewTaskButton.TabIndex = 18;
            this.addNewTaskButton.Text = "Add new";
            this.addNewTaskButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addNewTaskButton.UseAccentColor = false;
            this.addNewTaskButton.UseVisualStyleBackColor = true;
            // 
            // searchTaskButton
            // 
            this.searchTaskButton.AutoSize = false;
            this.searchTaskButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchTaskButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchTaskButton.Depth = 0;
            this.searchTaskButton.HighEmphasis = true;
            this.searchTaskButton.Icon = null;
            this.searchTaskButton.Location = new System.Drawing.Point(694, 80);
            this.searchTaskButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchTaskButton.Name = "searchTaskButton";
            this.searchTaskButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchTaskButton.Size = new System.Drawing.Size(255, 36);
            this.searchTaskButton.TabIndex = 17;
            this.searchTaskButton.Text = "Search";
            this.searchTaskButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchTaskButton.UseAccentColor = false;
            this.searchTaskButton.UseVisualStyleBackColor = true;
            // 
            // taskSearchTextBox
            // 
            this.taskSearchTextBox.AnimateReadOnly = false;
            this.taskSearchTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.taskSearchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.taskSearchTextBox.Depth = 0;
            this.taskSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskSearchTextBox.HideSelection = true;
            this.taskSearchTextBox.LeadingIcon = null;
            this.taskSearchTextBox.Location = new System.Drawing.Point(22, 68);
            this.taskSearchTextBox.MaxLength = 32767;
            this.taskSearchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.taskSearchTextBox.Name = "taskSearchTextBox";
            this.taskSearchTextBox.PasswordChar = '\0';
            this.taskSearchTextBox.PrefixSuffixText = null;
            this.taskSearchTextBox.ReadOnly = false;
            this.taskSearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.taskSearchTextBox.SelectedText = "";
            this.taskSearchTextBox.SelectionLength = 0;
            this.taskSearchTextBox.SelectionStart = 0;
            this.taskSearchTextBox.ShortcutsEnabled = true;
            this.taskSearchTextBox.Size = new System.Drawing.Size(628, 48);
            this.taskSearchTextBox.TabIndex = 16;
            this.taskSearchTextBox.TabStop = false;
            this.taskSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.taskSearchTextBox.TrailingIcon = null;
            this.taskSearchTextBox.UseSystemPasswordChar = false;
            // 
            // taskSearchLabel
            // 
            this.taskSearchLabel.AutoSize = true;
            this.taskSearchLabel.Depth = 0;
            this.taskSearchLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskSearchLabel.Location = new System.Drawing.Point(19, 33);
            this.taskSearchLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.taskSearchLabel.Name = "taskSearchLabel";
            this.taskSearchLabel.Size = new System.Drawing.Size(88, 19);
            this.taskSearchLabel.TabIndex = 15;
            this.taskSearchLabel.Text = "Search task:";
            // 
            // taskDataGridView
            // 
            this.taskDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.taskDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.taskDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.taskDataGridView.EnableHeadersVisualStyles = false;
            this.taskDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.taskDataGridView.Location = new System.Drawing.Point(22, 145);
            this.taskDataGridView.Name = "taskDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.taskDataGridView.Size = new System.Drawing.Size(883, 545);
            this.taskDataGridView.TabIndex = 10;
            // 
            // addEditTaskTabPage
            // 
            this.addEditTaskTabPage.Controls.Add(this.taskCancelButton);
            this.addEditTaskTabPage.Controls.Add(this.taskSaveButton);
            this.addEditTaskTabPage.Controls.Add(this.taskProjectIDLabel);
            this.addEditTaskTabPage.Controls.Add(this.taskProjectIDTextBox);
            this.addEditTaskTabPage.Controls.Add(this.taskStatusLabel);
            this.addEditTaskTabPage.Controls.Add(this.taskStatusTextBox);
            this.addEditTaskTabPage.Controls.Add(this.taskPriorityLabel);
            this.addEditTaskTabPage.Controls.Add(this.taskPriorityTextBox);
            this.addEditTaskTabPage.Controls.Add(this.dueDateTimePicker);
            this.addEditTaskTabPage.Controls.Add(this.taskDueDateLabel);
            this.addEditTaskTabPage.Controls.Add(this.taskDescriptionLabel);
            this.addEditTaskTabPage.Controls.Add(this.taskDescriptionTextBox);
            this.addEditTaskTabPage.Controls.Add(this.taskNameLabel);
            this.addEditTaskTabPage.Controls.Add(this.taskNameTextBox);
            this.addEditTaskTabPage.Controls.Add(this.taskIDLabel);
            this.addEditTaskTabPage.Controls.Add(this.taskIDTextBox);
            this.addEditTaskTabPage.ImageKey = "add.png";
            this.addEditTaskTabPage.Location = new System.Drawing.Point(4, 39);
            this.addEditTaskTabPage.Name = "addEditTaskTabPage";
            this.addEditTaskTabPage.Size = new System.Drawing.Size(1186, 690);
            this.addEditTaskTabPage.TabIndex = 6;
            this.addEditTaskTabPage.Text = "Add / Edit Task";
            this.addEditTaskTabPage.UseVisualStyleBackColor = true;
            // 
            // taskCancelButton
            // 
            this.taskCancelButton.AutoSize = false;
            this.taskCancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.taskCancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.taskCancelButton.Depth = 0;
            this.taskCancelButton.HighEmphasis = true;
            this.taskCancelButton.Icon = null;
            this.taskCancelButton.Location = new System.Drawing.Point(617, 517);
            this.taskCancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.taskCancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.taskCancelButton.Name = "taskCancelButton";
            this.taskCancelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.taskCancelButton.Size = new System.Drawing.Size(158, 36);
            this.taskCancelButton.TabIndex = 51;
            this.taskCancelButton.Text = "Cancel";
            this.taskCancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.taskCancelButton.UseAccentColor = true;
            this.taskCancelButton.UseVisualStyleBackColor = true;
            // 
            // taskSaveButton
            // 
            this.taskSaveButton.AutoSize = false;
            this.taskSaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.taskSaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.taskSaveButton.Depth = 0;
            this.taskSaveButton.HighEmphasis = true;
            this.taskSaveButton.Icon = null;
            this.taskSaveButton.Location = new System.Drawing.Point(407, 517);
            this.taskSaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.taskSaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.taskSaveButton.Name = "taskSaveButton";
            this.taskSaveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.taskSaveButton.Size = new System.Drawing.Size(158, 36);
            this.taskSaveButton.TabIndex = 50;
            this.taskSaveButton.Text = "Save";
            this.taskSaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.taskSaveButton.UseAccentColor = true;
            this.taskSaveButton.UseVisualStyleBackColor = true;
            // 
            // taskProjectIDLabel
            // 
            this.taskProjectIDLabel.AutoSize = true;
            this.taskProjectIDLabel.Depth = 0;
            this.taskProjectIDLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskProjectIDLabel.Location = new System.Drawing.Point(796, 345);
            this.taskProjectIDLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.taskProjectIDLabel.Name = "taskProjectIDLabel";
            this.taskProjectIDLabel.Size = new System.Drawing.Size(73, 19);
            this.taskProjectIDLabel.TabIndex = 49;
            this.taskProjectIDLabel.Text = "Project ID:";
            // 
            // taskProjectIDTextBox
            // 
            this.taskProjectIDTextBox.AnimateReadOnly = false;
            this.taskProjectIDTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.taskProjectIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.taskProjectIDTextBox.Depth = 0;
            this.taskProjectIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskProjectIDTextBox.HideSelection = true;
            this.taskProjectIDTextBox.LeadingIcon = null;
            this.taskProjectIDTextBox.Location = new System.Drawing.Point(799, 367);
            this.taskProjectIDTextBox.MaxLength = 32767;
            this.taskProjectIDTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.taskProjectIDTextBox.Name = "taskProjectIDTextBox";
            this.taskProjectIDTextBox.PasswordChar = '\0';
            this.taskProjectIDTextBox.PrefixSuffixText = null;
            this.taskProjectIDTextBox.ReadOnly = false;
            this.taskProjectIDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.taskProjectIDTextBox.SelectedText = "";
            this.taskProjectIDTextBox.SelectionLength = 0;
            this.taskProjectIDTextBox.SelectionStart = 0;
            this.taskProjectIDTextBox.ShortcutsEnabled = true;
            this.taskProjectIDTextBox.Size = new System.Drawing.Size(277, 48);
            this.taskProjectIDTextBox.TabIndex = 48;
            this.taskProjectIDTextBox.TabStop = false;
            this.taskProjectIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.taskProjectIDTextBox.TrailingIcon = null;
            this.taskProjectIDTextBox.UseSystemPasswordChar = false;
            // 
            // taskStatusLabel
            // 
            this.taskStatusLabel.AutoSize = true;
            this.taskStatusLabel.Depth = 0;
            this.taskStatusLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskStatusLabel.Location = new System.Drawing.Point(477, 345);
            this.taskStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.taskStatusLabel.Name = "taskStatusLabel";
            this.taskStatusLabel.Size = new System.Drawing.Size(51, 19);
            this.taskStatusLabel.TabIndex = 47;
            this.taskStatusLabel.Text = "Status:";
            // 
            // taskStatusTextBox
            // 
            this.taskStatusTextBox.AnimateReadOnly = false;
            this.taskStatusTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.taskStatusTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.taskStatusTextBox.Depth = 0;
            this.taskStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskStatusTextBox.HideSelection = true;
            this.taskStatusTextBox.LeadingIcon = null;
            this.taskStatusTextBox.Location = new System.Drawing.Point(480, 367);
            this.taskStatusTextBox.MaxLength = 32767;
            this.taskStatusTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.taskStatusTextBox.Name = "taskStatusTextBox";
            this.taskStatusTextBox.PasswordChar = '\0';
            this.taskStatusTextBox.PrefixSuffixText = null;
            this.taskStatusTextBox.ReadOnly = false;
            this.taskStatusTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.taskStatusTextBox.SelectedText = "";
            this.taskStatusTextBox.SelectionLength = 0;
            this.taskStatusTextBox.SelectionStart = 0;
            this.taskStatusTextBox.ShortcutsEnabled = true;
            this.taskStatusTextBox.Size = new System.Drawing.Size(277, 48);
            this.taskStatusTextBox.TabIndex = 46;
            this.taskStatusTextBox.TabStop = false;
            this.taskStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.taskStatusTextBox.TrailingIcon = null;
            this.taskStatusTextBox.UseSystemPasswordChar = false;
            // 
            // taskPriorityLabel
            // 
            this.taskPriorityLabel.AutoSize = true;
            this.taskPriorityLabel.Depth = 0;
            this.taskPriorityLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskPriorityLabel.Location = new System.Drawing.Point(149, 345);
            this.taskPriorityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.taskPriorityLabel.Name = "taskPriorityLabel";
            this.taskPriorityLabel.Size = new System.Drawing.Size(55, 19);
            this.taskPriorityLabel.TabIndex = 45;
            this.taskPriorityLabel.Text = "Priority:";
            // 
            // taskPriorityTextBox
            // 
            this.taskPriorityTextBox.AnimateReadOnly = false;
            this.taskPriorityTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.taskPriorityTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.taskPriorityTextBox.Depth = 0;
            this.taskPriorityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskPriorityTextBox.HideSelection = true;
            this.taskPriorityTextBox.LeadingIcon = null;
            this.taskPriorityTextBox.Location = new System.Drawing.Point(152, 367);
            this.taskPriorityTextBox.MaxLength = 32767;
            this.taskPriorityTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.taskPriorityTextBox.Name = "taskPriorityTextBox";
            this.taskPriorityTextBox.PasswordChar = '\0';
            this.taskPriorityTextBox.PrefixSuffixText = null;
            this.taskPriorityTextBox.ReadOnly = false;
            this.taskPriorityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.taskPriorityTextBox.SelectedText = "";
            this.taskPriorityTextBox.SelectionLength = 0;
            this.taskPriorityTextBox.SelectionStart = 0;
            this.taskPriorityTextBox.ShortcutsEnabled = true;
            this.taskPriorityTextBox.Size = new System.Drawing.Size(277, 48);
            this.taskPriorityTextBox.TabIndex = 44;
            this.taskPriorityTextBox.TabStop = false;
            this.taskPriorityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.taskPriorityTextBox.TrailingIcon = null;
            this.taskPriorityTextBox.UseSystemPasswordChar = false;
            // 
            // dueDateTimePicker
            // 
            this.dueDateTimePicker.Location = new System.Drawing.Point(799, 248);
            this.dueDateTimePicker.Name = "dueDateTimePicker";
            this.dueDateTimePicker.Size = new System.Drawing.Size(215, 20);
            this.dueDateTimePicker.TabIndex = 43;
            this.dueDateTimePicker.Value = new System.DateTime(2023, 5, 28, 12, 0, 0, 0);
            // 
            // taskDueDateLabel
            // 
            this.taskDueDateLabel.AutoSize = true;
            this.taskDueDateLabel.Depth = 0;
            this.taskDueDateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskDueDateLabel.Location = new System.Drawing.Point(796, 209);
            this.taskDueDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.taskDueDateLabel.Name = "taskDueDateLabel";
            this.taskDueDateLabel.Size = new System.Drawing.Size(70, 19);
            this.taskDueDateLabel.TabIndex = 42;
            this.taskDueDateLabel.Text = "Due Date:";
            // 
            // taskDescriptionLabel
            // 
            this.taskDescriptionLabel.AutoSize = true;
            this.taskDescriptionLabel.Depth = 0;
            this.taskDescriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskDescriptionLabel.Location = new System.Drawing.Point(477, 209);
            this.taskDescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.taskDescriptionLabel.Name = "taskDescriptionLabel";
            this.taskDescriptionLabel.Size = new System.Drawing.Size(85, 19);
            this.taskDescriptionLabel.TabIndex = 40;
            this.taskDescriptionLabel.Text = "Description:";
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.AnimateReadOnly = false;
            this.taskDescriptionTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.taskDescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.taskDescriptionTextBox.Depth = 0;
            this.taskDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskDescriptionTextBox.HideSelection = true;
            this.taskDescriptionTextBox.LeadingIcon = null;
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(480, 231);
            this.taskDescriptionTextBox.MaxLength = 32767;
            this.taskDescriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.PasswordChar = '\0';
            this.taskDescriptionTextBox.PrefixSuffixText = null;
            this.taskDescriptionTextBox.ReadOnly = false;
            this.taskDescriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.taskDescriptionTextBox.SelectedText = "";
            this.taskDescriptionTextBox.SelectionLength = 0;
            this.taskDescriptionTextBox.SelectionStart = 0;
            this.taskDescriptionTextBox.ShortcutsEnabled = true;
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(277, 48);
            this.taskDescriptionTextBox.TabIndex = 39;
            this.taskDescriptionTextBox.TabStop = false;
            this.taskDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.taskDescriptionTextBox.TrailingIcon = null;
            this.taskDescriptionTextBox.UseSystemPasswordChar = false;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Depth = 0;
            this.taskNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskNameLabel.Location = new System.Drawing.Point(149, 209);
            this.taskNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(47, 19);
            this.taskNameLabel.TabIndex = 38;
            this.taskNameLabel.Text = "Name:";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.AnimateReadOnly = false;
            this.taskNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.taskNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.taskNameTextBox.Depth = 0;
            this.taskNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskNameTextBox.HideSelection = true;
            this.taskNameTextBox.LeadingIcon = null;
            this.taskNameTextBox.Location = new System.Drawing.Point(152, 231);
            this.taskNameTextBox.MaxLength = 32767;
            this.taskNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.PasswordChar = '\0';
            this.taskNameTextBox.PrefixSuffixText = null;
            this.taskNameTextBox.ReadOnly = false;
            this.taskNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.taskNameTextBox.SelectedText = "";
            this.taskNameTextBox.SelectionLength = 0;
            this.taskNameTextBox.SelectionStart = 0;
            this.taskNameTextBox.ShortcutsEnabled = true;
            this.taskNameTextBox.Size = new System.Drawing.Size(277, 48);
            this.taskNameTextBox.TabIndex = 37;
            this.taskNameTextBox.TabStop = false;
            this.taskNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.taskNameTextBox.TrailingIcon = null;
            this.taskNameTextBox.UseSystemPasswordChar = false;
            // 
            // taskIDLabel
            // 
            this.taskIDLabel.AutoSize = true;
            this.taskIDLabel.Depth = 0;
            this.taskIDLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskIDLabel.Location = new System.Drawing.Point(148, 111);
            this.taskIDLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.taskIDLabel.Name = "taskIDLabel";
            this.taskIDLabel.Size = new System.Drawing.Size(59, 19);
            this.taskIDLabel.TabIndex = 36;
            this.taskIDLabel.Text = "Task ID:";
            // 
            // taskIDTextBox
            // 
            this.taskIDTextBox.AnimateReadOnly = false;
            this.taskIDTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.taskIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.taskIDTextBox.Depth = 0;
            this.taskIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskIDTextBox.HideSelection = true;
            this.taskIDTextBox.LeadingIcon = null;
            this.taskIDTextBox.Location = new System.Drawing.Point(151, 133);
            this.taskIDTextBox.MaxLength = 32767;
            this.taskIDTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.taskIDTextBox.Name = "taskIDTextBox";
            this.taskIDTextBox.PasswordChar = '\0';
            this.taskIDTextBox.PrefixSuffixText = null;
            this.taskIDTextBox.ReadOnly = false;
            this.taskIDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.taskIDTextBox.SelectedText = "";
            this.taskIDTextBox.SelectionLength = 0;
            this.taskIDTextBox.SelectionStart = 0;
            this.taskIDTextBox.ShortcutsEnabled = true;
            this.taskIDTextBox.Size = new System.Drawing.Size(277, 48);
            this.taskIDTextBox.TabIndex = 35;
            this.taskIDTextBox.TabStop = false;
            this.taskIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.taskIDTextBox.TrailingIcon = null;
            this.taskIDTextBox.UseSystemPasswordChar = false;
            // 
            // projectsTabPage
            // 
            this.projectsTabPage.Controls.Add(this.projectsDataGridView);
            this.projectsTabPage.ImageKey = "projects.png";
            this.projectsTabPage.Location = new System.Drawing.Point(4, 39);
            this.projectsTabPage.Name = "projectsTabPage";
            this.projectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectsTabPage.Size = new System.Drawing.Size(1186, 690);
            this.projectsTabPage.TabIndex = 1;
            this.projectsTabPage.Text = "Projects";
            this.projectsTabPage.UseVisualStyleBackColor = true;
            // 
            // projectsDataGridView
            // 
            this.projectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGridView.Location = new System.Drawing.Point(130, 73);
            this.projectsDataGridView.Name = "projectsDataGridView";
            this.projectsDataGridView.Size = new System.Drawing.Size(927, 545);
            this.projectsDataGridView.TabIndex = 11;
            // 
            // taskAssignmentsTabPage
            // 
            this.taskAssignmentsTabPage.ImageKey = "task_assignments.png";
            this.taskAssignmentsTabPage.Location = new System.Drawing.Point(4, 39);
            this.taskAssignmentsTabPage.Name = "taskAssignmentsTabPage";
            this.taskAssignmentsTabPage.Size = new System.Drawing.Size(1186, 690);
            this.taskAssignmentsTabPage.TabIndex = 2;
            this.taskAssignmentsTabPage.Text = "Task Assignments";
            this.taskAssignmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // commentsTabPage
            // 
            this.commentsTabPage.ImageKey = "comments.png";
            this.commentsTabPage.Location = new System.Drawing.Point(4, 39);
            this.commentsTabPage.Name = "commentsTabPage";
            this.commentsTabPage.Size = new System.Drawing.Size(1186, 690);
            this.commentsTabPage.TabIndex = 3;
            this.commentsTabPage.Text = "Comments";
            this.commentsTabPage.UseVisualStyleBackColor = true;
            // 
            // usersTabPage
            // 
            this.usersTabPage.ImageKey = "users.png";
            this.usersTabPage.Location = new System.Drawing.Point(4, 39);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Size = new System.Drawing.Size(1186, 690);
            this.usersTabPage.TabIndex = 4;
            this.usersTabPage.Text = "Users";
            this.usersTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.ImageKey = "settings.png";
            this.settingsTabPage.Location = new System.Drawing.Point(4, 39);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(1186, 690);
            this.settingsTabPage.TabIndex = 5;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tasks.png");
            this.imageList1.Images.SetKeyName(1, "projects.png");
            this.imageList1.Images.SetKeyName(2, "task_assignments.png");
            this.imageList1.Images.SetKeyName(3, "comments.png");
            this.imageList1.Images.SetKeyName(4, "users.png");
            this.imageList1.Images.SetKeyName(5, "settings.png");
            this.imageList1.Images.SetKeyName(6, "add.png");
            this.imageList1.Images.SetKeyName(7, "logout.png");
            this.imageList1.Images.SetKeyName(8, "exit.png");
            // 
            // logoutTabPage
            // 
            this.logoutTabPage.ImageKey = "logout.png";
            this.logoutTabPage.Location = new System.Drawing.Point(4, 39);
            this.logoutTabPage.Name = "logoutTabPage";
            this.logoutTabPage.Size = new System.Drawing.Size(1186, 690);
            this.logoutTabPage.TabIndex = 7;
            this.logoutTabPage.Text = "Logout";
            this.logoutTabPage.UseVisualStyleBackColor = true;
            // 
            // exitTabPage
            // 
            this.exitTabPage.ImageKey = "exit.png";
            this.exitTabPage.Location = new System.Drawing.Point(4, 39);
            this.exitTabPage.Name = "exitTabPage";
            this.exitTabPage.Size = new System.Drawing.Size(1186, 690);
            this.exitTabPage.TabIndex = 8;
            this.exitTabPage.Text = "Exit";
            this.exitTabPage.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "MainView";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tasksTabPage.ResumeLayout(false);
            this.tasksTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).EndInit();
            this.addEditTaskTabPage.ResumeLayout(false);
            this.addEditTaskTabPage.PerformLayout();
            this.projectsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tasksTabPage;
        private System.Windows.Forms.TabPage projectsTabPage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage taskAssignmentsTabPage;
        private System.Windows.Forms.TabPage commentsTabPage;
        private System.Windows.Forms.TabPage usersTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private MaterialSkin.Controls.MaterialButton searchTaskButton;
        private MaterialSkin.Controls.MaterialTextBox2 taskSearchTextBox;
        private MaterialSkin.Controls.MaterialLabel taskSearchLabel;
        private System.Windows.Forms.DataGridView taskDataGridView;
        private MaterialSkin.Controls.MaterialButton deleteTaskButton;
        private MaterialSkin.Controls.MaterialButton editTaskButton;
        private MaterialSkin.Controls.MaterialButton addNewTaskButton;
        private System.Windows.Forms.DataGridView projectsDataGridView;
        private System.Windows.Forms.TabPage addEditTaskTabPage;
        private MaterialSkin.Controls.MaterialTextBox2 taskIDTextBox;
        private MaterialSkin.Controls.MaterialLabel taskIDLabel;
        private MaterialSkin.Controls.MaterialLabel taskDueDateLabel;
        private MaterialSkin.Controls.MaterialLabel taskDescriptionLabel;
        private MaterialSkin.Controls.MaterialTextBox2 taskDescriptionTextBox;
        private MaterialSkin.Controls.MaterialLabel taskNameLabel;
        private MaterialSkin.Controls.MaterialTextBox2 taskNameTextBox;
        private System.Windows.Forms.DateTimePicker dueDateTimePicker;
        private MaterialSkin.Controls.MaterialLabel taskProjectIDLabel;
        private MaterialSkin.Controls.MaterialTextBox2 taskProjectIDTextBox;
        private MaterialSkin.Controls.MaterialLabel taskStatusLabel;
        private MaterialSkin.Controls.MaterialTextBox2 taskStatusTextBox;
        private MaterialSkin.Controls.MaterialLabel taskPriorityLabel;
        private MaterialSkin.Controls.MaterialTextBox2 taskPriorityTextBox;
        private MaterialSkin.Controls.MaterialButton taskCancelButton;
        private MaterialSkin.Controls.MaterialButton taskSaveButton;
        private System.Windows.Forms.TabPage logoutTabPage;
        private System.Windows.Forms.TabPage exitTabPage;
    }
}