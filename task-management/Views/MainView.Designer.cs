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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cancelTaskButton = new MaterialSkin.Controls.MaterialButton();
            this.saveTaskButton = new MaterialSkin.Controls.MaterialButton();
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
            this.deleteProjectButton = new MaterialSkin.Controls.MaterialButton();
            this.editProjectButton = new MaterialSkin.Controls.MaterialButton();
            this.addNewProjectButton = new MaterialSkin.Controls.MaterialButton();
            this.searchProjectButton = new MaterialSkin.Controls.MaterialButton();
            this.projectSearchTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.projectSearchLabel = new MaterialSkin.Controls.MaterialLabel();
            this.projectDataGridView = new System.Windows.Forms.DataGridView();
            this.addProjectTabPage = new System.Windows.Forms.TabPage();
            this.projectEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectEndDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cancelProjectButton = new MaterialSkin.Controls.MaterialButton();
            this.saveProjectButton = new MaterialSkin.Controls.MaterialButton();
            this.projectStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectStartDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.projectDescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.projectDescriptionTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.projectNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.projectNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.projectIDLabel = new MaterialSkin.Controls.MaterialLabel();
            this.projectIDTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.taskAssignmentsTabPage = new System.Windows.Forms.TabPage();
            this.addTaskAssignmentTabPage = new System.Windows.Forms.TabPage();
            this.commentsTabPage = new System.Windows.Forms.TabPage();
            this.addCommentTabPage = new System.Windows.Forms.TabPage();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.addUserTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.darkThemeMaterialSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.logoutTabPage = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.logoutMaterialButton = new MaterialSkin.Controls.MaterialButton();
            this.exitTabPage = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.exitMaterialButton = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.userTabPage = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.tasksTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).BeginInit();
            this.addEditTaskTabPage.SuspendLayout();
            this.projectsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).BeginInit();
            this.addProjectTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.logoutTabPage.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.exitTabPage.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tasksTabPage);
            this.materialTabControl1.Controls.Add(this.addEditTaskTabPage);
            this.materialTabControl1.Controls.Add(this.projectsTabPage);
            this.materialTabControl1.Controls.Add(this.addProjectTabPage);
            this.materialTabControl1.Controls.Add(this.taskAssignmentsTabPage);
            this.materialTabControl1.Controls.Add(this.addTaskAssignmentTabPage);
            this.materialTabControl1.Controls.Add(this.commentsTabPage);
            this.materialTabControl1.Controls.Add(this.addCommentTabPage);
            this.materialTabControl1.Controls.Add(this.usersTabPage);
            this.materialTabControl1.Controls.Add(this.addUserTabPage);
            this.materialTabControl1.Controls.Add(this.settingsTabPage);
            this.materialTabControl1.Controls.Add(this.userTabPage);
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
            this.tasksTabPage.Location = new System.Drawing.Point(4, 74);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tasksTabPage.Size = new System.Drawing.Size(1186, 655);
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
            this.deleteTaskButton.Location = new System.Drawing.Point(932, 311);
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
            this.editTaskButton.Location = new System.Drawing.Point(932, 240);
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
            this.addNewTaskButton.Location = new System.Drawing.Point(932, 172);
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
            this.searchTaskButton.Location = new System.Drawing.Point(630, 80);
            this.searchTaskButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchTaskButton.Name = "searchTaskButton";
            this.searchTaskButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchTaskButton.Size = new System.Drawing.Size(211, 36);
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
            this.taskSearchTextBox.Size = new System.Drawing.Size(570, 48);
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.taskDataGridView.DefaultCellStyle = dataGridViewCellStyle26;
            this.taskDataGridView.EnableHeadersVisualStyles = false;
            this.taskDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.taskDataGridView.Location = new System.Drawing.Point(22, 145);
            this.taskDataGridView.Name = "taskDataGridView";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.taskDataGridView.Size = new System.Drawing.Size(883, 510);
            this.taskDataGridView.TabIndex = 10;
            // 
            // addEditTaskTabPage
            // 
            this.addEditTaskTabPage.BackColor = System.Drawing.Color.Transparent;
            this.addEditTaskTabPage.Controls.Add(this.cancelTaskButton);
            this.addEditTaskTabPage.Controls.Add(this.saveTaskButton);
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
            this.addEditTaskTabPage.Location = new System.Drawing.Point(4, 74);
            this.addEditTaskTabPage.Name = "addEditTaskTabPage";
            this.addEditTaskTabPage.Size = new System.Drawing.Size(1186, 655);
            this.addEditTaskTabPage.TabIndex = 6;
            this.addEditTaskTabPage.Text = "Add / Edit Task";
            // 
            // cancelTaskButton
            // 
            this.cancelTaskButton.AutoSize = false;
            this.cancelTaskButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelTaskButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelTaskButton.Depth = 0;
            this.cancelTaskButton.HighEmphasis = true;
            this.cancelTaskButton.Icon = null;
            this.cancelTaskButton.Location = new System.Drawing.Point(617, 517);
            this.cancelTaskButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelTaskButton.Name = "cancelTaskButton";
            this.cancelTaskButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelTaskButton.Size = new System.Drawing.Size(158, 36);
            this.cancelTaskButton.TabIndex = 51;
            this.cancelTaskButton.Text = "Cancel";
            this.cancelTaskButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelTaskButton.UseAccentColor = true;
            this.cancelTaskButton.UseVisualStyleBackColor = true;
            // 
            // saveTaskButton
            // 
            this.saveTaskButton.AutoSize = false;
            this.saveTaskButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveTaskButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveTaskButton.Depth = 0;
            this.saveTaskButton.HighEmphasis = true;
            this.saveTaskButton.Icon = null;
            this.saveTaskButton.Location = new System.Drawing.Point(407, 517);
            this.saveTaskButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveTaskButton.Name = "saveTaskButton";
            this.saveTaskButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveTaskButton.Size = new System.Drawing.Size(158, 36);
            this.saveTaskButton.TabIndex = 50;
            this.saveTaskButton.Text = "Save";
            this.saveTaskButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveTaskButton.UseAccentColor = true;
            this.saveTaskButton.UseVisualStyleBackColor = true;
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
            this.dueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            this.projectsTabPage.Controls.Add(this.deleteProjectButton);
            this.projectsTabPage.Controls.Add(this.editProjectButton);
            this.projectsTabPage.Controls.Add(this.addNewProjectButton);
            this.projectsTabPage.Controls.Add(this.searchProjectButton);
            this.projectsTabPage.Controls.Add(this.projectSearchTextBox);
            this.projectsTabPage.Controls.Add(this.projectSearchLabel);
            this.projectsTabPage.Controls.Add(this.projectDataGridView);
            this.projectsTabPage.ImageKey = "projects.png";
            this.projectsTabPage.Location = new System.Drawing.Point(4, 74);
            this.projectsTabPage.Name = "projectsTabPage";
            this.projectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectsTabPage.Size = new System.Drawing.Size(1186, 655);
            this.projectsTabPage.TabIndex = 1;
            this.projectsTabPage.Text = "Projects";
            this.projectsTabPage.UseVisualStyleBackColor = true;
            // 
            // deleteProjectButton
            // 
            this.deleteProjectButton.AutoSize = false;
            this.deleteProjectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteProjectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteProjectButton.Depth = 0;
            this.deleteProjectButton.HighEmphasis = true;
            this.deleteProjectButton.Icon = null;
            this.deleteProjectButton.Location = new System.Drawing.Point(932, 311);
            this.deleteProjectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteProjectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteProjectButton.Name = "deleteProjectButton";
            this.deleteProjectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteProjectButton.Size = new System.Drawing.Size(155, 36);
            this.deleteProjectButton.TabIndex = 27;
            this.deleteProjectButton.Text = "Delete";
            this.deleteProjectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteProjectButton.UseAccentColor = false;
            this.deleteProjectButton.UseVisualStyleBackColor = true;
            // 
            // editProjectButton
            // 
            this.editProjectButton.AutoSize = false;
            this.editProjectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editProjectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editProjectButton.Depth = 0;
            this.editProjectButton.HighEmphasis = true;
            this.editProjectButton.Icon = null;
            this.editProjectButton.Location = new System.Drawing.Point(932, 240);
            this.editProjectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editProjectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.editProjectButton.Name = "editProjectButton";
            this.editProjectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editProjectButton.Size = new System.Drawing.Size(155, 36);
            this.editProjectButton.TabIndex = 26;
            this.editProjectButton.Text = "Edit";
            this.editProjectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editProjectButton.UseAccentColor = false;
            this.editProjectButton.UseVisualStyleBackColor = true;
            // 
            // addNewProjectButton
            // 
            this.addNewProjectButton.AutoSize = false;
            this.addNewProjectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addNewProjectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addNewProjectButton.Depth = 0;
            this.addNewProjectButton.HighEmphasis = true;
            this.addNewProjectButton.Icon = null;
            this.addNewProjectButton.Location = new System.Drawing.Point(932, 172);
            this.addNewProjectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addNewProjectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addNewProjectButton.Name = "addNewProjectButton";
            this.addNewProjectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addNewProjectButton.Size = new System.Drawing.Size(155, 36);
            this.addNewProjectButton.TabIndex = 25;
            this.addNewProjectButton.Text = "Add new";
            this.addNewProjectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addNewProjectButton.UseAccentColor = false;
            this.addNewProjectButton.UseVisualStyleBackColor = true;
            // 
            // searchProjectButton
            // 
            this.searchProjectButton.AutoSize = false;
            this.searchProjectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchProjectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchProjectButton.Depth = 0;
            this.searchProjectButton.HighEmphasis = true;
            this.searchProjectButton.Icon = null;
            this.searchProjectButton.Location = new System.Drawing.Point(630, 80);
            this.searchProjectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchProjectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchProjectButton.Name = "searchProjectButton";
            this.searchProjectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchProjectButton.Size = new System.Drawing.Size(211, 36);
            this.searchProjectButton.TabIndex = 24;
            this.searchProjectButton.Text = "Search";
            this.searchProjectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchProjectButton.UseAccentColor = false;
            this.searchProjectButton.UseVisualStyleBackColor = true;
            // 
            // projectSearchTextBox
            // 
            this.projectSearchTextBox.AnimateReadOnly = false;
            this.projectSearchTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.projectSearchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.projectSearchTextBox.Depth = 0;
            this.projectSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectSearchTextBox.HideSelection = true;
            this.projectSearchTextBox.LeadingIcon = null;
            this.projectSearchTextBox.Location = new System.Drawing.Point(22, 68);
            this.projectSearchTextBox.MaxLength = 32767;
            this.projectSearchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.projectSearchTextBox.Name = "projectSearchTextBox";
            this.projectSearchTextBox.PasswordChar = '\0';
            this.projectSearchTextBox.PrefixSuffixText = null;
            this.projectSearchTextBox.ReadOnly = false;
            this.projectSearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projectSearchTextBox.SelectedText = "";
            this.projectSearchTextBox.SelectionLength = 0;
            this.projectSearchTextBox.SelectionStart = 0;
            this.projectSearchTextBox.ShortcutsEnabled = true;
            this.projectSearchTextBox.Size = new System.Drawing.Size(570, 48);
            this.projectSearchTextBox.TabIndex = 23;
            this.projectSearchTextBox.TabStop = false;
            this.projectSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.projectSearchTextBox.TrailingIcon = null;
            this.projectSearchTextBox.UseSystemPasswordChar = false;
            // 
            // projectSearchLabel
            // 
            this.projectSearchLabel.AutoSize = true;
            this.projectSearchLabel.Depth = 0;
            this.projectSearchLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectSearchLabel.Location = new System.Drawing.Point(19, 33);
            this.projectSearchLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.projectSearchLabel.Name = "projectSearchLabel";
            this.projectSearchLabel.Size = new System.Drawing.Size(106, 19);
            this.projectSearchLabel.TabIndex = 22;
            this.projectSearchLabel.Text = "Search project:";
            // 
            // projectDataGridView
            // 
            this.projectDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.projectDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectDataGridView.DefaultCellStyle = dataGridViewCellStyle29;
            this.projectDataGridView.EnableHeadersVisualStyles = false;
            this.projectDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.projectDataGridView.Location = new System.Drawing.Point(22, 145);
            this.projectDataGridView.Name = "projectDataGridView";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.projectDataGridView.Size = new System.Drawing.Size(883, 580);
            this.projectDataGridView.TabIndex = 21;
            // 
            // addProjectTabPage
            // 
            this.addProjectTabPage.Controls.Add(this.projectEndDateTimePicker);
            this.addProjectTabPage.Controls.Add(this.projectEndDateLabel);
            this.addProjectTabPage.Controls.Add(this.cancelProjectButton);
            this.addProjectTabPage.Controls.Add(this.saveProjectButton);
            this.addProjectTabPage.Controls.Add(this.projectStartDateTimePicker);
            this.addProjectTabPage.Controls.Add(this.projectStartDateLabel);
            this.addProjectTabPage.Controls.Add(this.projectDescriptionLabel);
            this.addProjectTabPage.Controls.Add(this.projectDescriptionTextBox);
            this.addProjectTabPage.Controls.Add(this.projectNameLabel);
            this.addProjectTabPage.Controls.Add(this.projectNameTextBox);
            this.addProjectTabPage.Controls.Add(this.projectIDLabel);
            this.addProjectTabPage.Controls.Add(this.projectIDTextBox);
            this.addProjectTabPage.ImageKey = "add_project.png";
            this.addProjectTabPage.Location = new System.Drawing.Point(4, 39);
            this.addProjectTabPage.Name = "addProjectTabPage";
            this.addProjectTabPage.Size = new System.Drawing.Size(1186, 690);
            this.addProjectTabPage.TabIndex = 9;
            this.addProjectTabPage.Text = "Add Project";
            this.addProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // projectEndDateTimePicker
            // 
            this.projectEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.projectEndDateTimePicker.Location = new System.Drawing.Point(461, 359);
            this.projectEndDateTimePicker.Name = "projectEndDateTimePicker";
            this.projectEndDateTimePicker.Size = new System.Drawing.Size(215, 20);
            this.projectEndDateTimePicker.TabIndex = 69;
            this.projectEndDateTimePicker.Value = new System.DateTime(2023, 5, 28, 12, 0, 0, 0);
            // 
            // projectEndDateLabel
            // 
            this.projectEndDateLabel.AutoSize = true;
            this.projectEndDateLabel.Depth = 0;
            this.projectEndDateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectEndDateLabel.Location = new System.Drawing.Point(458, 320);
            this.projectEndDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.projectEndDateLabel.Name = "projectEndDateLabel";
            this.projectEndDateLabel.Size = new System.Drawing.Size(70, 19);
            this.projectEndDateLabel.TabIndex = 68;
            this.projectEndDateLabel.Text = "Due Date:";
            // 
            // cancelProjectButton
            // 
            this.cancelProjectButton.AutoSize = false;
            this.cancelProjectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelProjectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelProjectButton.Depth = 0;
            this.cancelProjectButton.HighEmphasis = true;
            this.cancelProjectButton.Icon = null;
            this.cancelProjectButton.Location = new System.Drawing.Point(598, 512);
            this.cancelProjectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelProjectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelProjectButton.Name = "cancelProjectButton";
            this.cancelProjectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelProjectButton.Size = new System.Drawing.Size(158, 36);
            this.cancelProjectButton.TabIndex = 67;
            this.cancelProjectButton.Text = "Cancel";
            this.cancelProjectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelProjectButton.UseAccentColor = true;
            this.cancelProjectButton.UseVisualStyleBackColor = true;
            // 
            // saveProjectButton
            // 
            this.saveProjectButton.AutoSize = false;
            this.saveProjectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveProjectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveProjectButton.Depth = 0;
            this.saveProjectButton.HighEmphasis = true;
            this.saveProjectButton.Icon = null;
            this.saveProjectButton.Location = new System.Drawing.Point(388, 512);
            this.saveProjectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveProjectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveProjectButton.Name = "saveProjectButton";
            this.saveProjectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveProjectButton.Size = new System.Drawing.Size(158, 36);
            this.saveProjectButton.TabIndex = 66;
            this.saveProjectButton.Text = "Save";
            this.saveProjectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveProjectButton.UseAccentColor = true;
            this.saveProjectButton.UseVisualStyleBackColor = true;
            // 
            // projectStartDateTimePicker
            // 
            this.projectStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.projectStartDateTimePicker.Location = new System.Drawing.Point(133, 359);
            this.projectStartDateTimePicker.Name = "projectStartDateTimePicker";
            this.projectStartDateTimePicker.Size = new System.Drawing.Size(215, 20);
            this.projectStartDateTimePicker.TabIndex = 59;
            this.projectStartDateTimePicker.Value = new System.DateTime(2023, 5, 28, 12, 0, 0, 0);
            // 
            // projectStartDateLabel
            // 
            this.projectStartDateLabel.AutoSize = true;
            this.projectStartDateLabel.Depth = 0;
            this.projectStartDateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectStartDateLabel.Location = new System.Drawing.Point(130, 320);
            this.projectStartDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.projectStartDateLabel.Name = "projectStartDateLabel";
            this.projectStartDateLabel.Size = new System.Drawing.Size(70, 19);
            this.projectStartDateLabel.TabIndex = 58;
            this.projectStartDateLabel.Text = "Due Date:";
            // 
            // projectDescriptionLabel
            // 
            this.projectDescriptionLabel.AutoSize = true;
            this.projectDescriptionLabel.Depth = 0;
            this.projectDescriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectDescriptionLabel.Location = new System.Drawing.Point(458, 204);
            this.projectDescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.projectDescriptionLabel.Name = "projectDescriptionLabel";
            this.projectDescriptionLabel.Size = new System.Drawing.Size(85, 19);
            this.projectDescriptionLabel.TabIndex = 57;
            this.projectDescriptionLabel.Text = "Description:";
            // 
            // projectDescriptionTextBox
            // 
            this.projectDescriptionTextBox.AnimateReadOnly = false;
            this.projectDescriptionTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.projectDescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.projectDescriptionTextBox.Depth = 0;
            this.projectDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectDescriptionTextBox.HideSelection = true;
            this.projectDescriptionTextBox.LeadingIcon = null;
            this.projectDescriptionTextBox.Location = new System.Drawing.Point(461, 226);
            this.projectDescriptionTextBox.MaxLength = 32767;
            this.projectDescriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            this.projectDescriptionTextBox.PasswordChar = '\0';
            this.projectDescriptionTextBox.PrefixSuffixText = null;
            this.projectDescriptionTextBox.ReadOnly = false;
            this.projectDescriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projectDescriptionTextBox.SelectedText = "";
            this.projectDescriptionTextBox.SelectionLength = 0;
            this.projectDescriptionTextBox.SelectionStart = 0;
            this.projectDescriptionTextBox.ShortcutsEnabled = true;
            this.projectDescriptionTextBox.Size = new System.Drawing.Size(277, 48);
            this.projectDescriptionTextBox.TabIndex = 56;
            this.projectDescriptionTextBox.TabStop = false;
            this.projectDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.projectDescriptionTextBox.TrailingIcon = null;
            this.projectDescriptionTextBox.UseSystemPasswordChar = false;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Depth = 0;
            this.projectNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectNameLabel.Location = new System.Drawing.Point(130, 204);
            this.projectNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(47, 19);
            this.projectNameLabel.TabIndex = 55;
            this.projectNameLabel.Text = "Name:";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.AnimateReadOnly = false;
            this.projectNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.projectNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.projectNameTextBox.Depth = 0;
            this.projectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectNameTextBox.HideSelection = true;
            this.projectNameTextBox.LeadingIcon = null;
            this.projectNameTextBox.Location = new System.Drawing.Point(133, 226);
            this.projectNameTextBox.MaxLength = 32767;
            this.projectNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.PasswordChar = '\0';
            this.projectNameTextBox.PrefixSuffixText = null;
            this.projectNameTextBox.ReadOnly = false;
            this.projectNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projectNameTextBox.SelectedText = "";
            this.projectNameTextBox.SelectionLength = 0;
            this.projectNameTextBox.SelectionStart = 0;
            this.projectNameTextBox.ShortcutsEnabled = true;
            this.projectNameTextBox.Size = new System.Drawing.Size(277, 48);
            this.projectNameTextBox.TabIndex = 54;
            this.projectNameTextBox.TabStop = false;
            this.projectNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.projectNameTextBox.TrailingIcon = null;
            this.projectNameTextBox.UseSystemPasswordChar = false;
            // 
            // projectIDLabel
            // 
            this.projectIDLabel.AutoSize = true;
            this.projectIDLabel.Depth = 0;
            this.projectIDLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectIDLabel.Location = new System.Drawing.Point(129, 106);
            this.projectIDLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.projectIDLabel.Name = "projectIDLabel";
            this.projectIDLabel.Size = new System.Drawing.Size(73, 19);
            this.projectIDLabel.TabIndex = 53;
            this.projectIDLabel.Text = "Project ID:";
            // 
            // projectIDTextBox
            // 
            this.projectIDTextBox.AnimateReadOnly = false;
            this.projectIDTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.projectIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.projectIDTextBox.Depth = 0;
            this.projectIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectIDTextBox.HideSelection = true;
            this.projectIDTextBox.LeadingIcon = null;
            this.projectIDTextBox.Location = new System.Drawing.Point(132, 128);
            this.projectIDTextBox.MaxLength = 32767;
            this.projectIDTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.projectIDTextBox.Name = "projectIDTextBox";
            this.projectIDTextBox.PasswordChar = '\0';
            this.projectIDTextBox.PrefixSuffixText = null;
            this.projectIDTextBox.ReadOnly = false;
            this.projectIDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projectIDTextBox.SelectedText = "";
            this.projectIDTextBox.SelectionLength = 0;
            this.projectIDTextBox.SelectionStart = 0;
            this.projectIDTextBox.ShortcutsEnabled = true;
            this.projectIDTextBox.Size = new System.Drawing.Size(277, 48);
            this.projectIDTextBox.TabIndex = 52;
            this.projectIDTextBox.TabStop = false;
            this.projectIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.projectIDTextBox.TrailingIcon = null;
            this.projectIDTextBox.UseSystemPasswordChar = false;
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
            // addTaskAssignmentTabPage
            // 
            this.addTaskAssignmentTabPage.ImageKey = "add_task_assignment.png";
            this.addTaskAssignmentTabPage.Location = new System.Drawing.Point(4, 39);
            this.addTaskAssignmentTabPage.Name = "addTaskAssignmentTabPage";
            this.addTaskAssignmentTabPage.Size = new System.Drawing.Size(1186, 690);
            this.addTaskAssignmentTabPage.TabIndex = 10;
            this.addTaskAssignmentTabPage.Text = "Add Task Assignment";
            this.addTaskAssignmentTabPage.UseVisualStyleBackColor = true;
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
            // addCommentTabPage
            // 
            this.addCommentTabPage.ImageKey = "add_comment.png";
            this.addCommentTabPage.Location = new System.Drawing.Point(4, 39);
            this.addCommentTabPage.Name = "addCommentTabPage";
            this.addCommentTabPage.Size = new System.Drawing.Size(1186, 690);
            this.addCommentTabPage.TabIndex = 11;
            this.addCommentTabPage.Text = "Add Comment";
            this.addCommentTabPage.UseVisualStyleBackColor = true;
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
            // addUserTabPage
            // 
            this.addUserTabPage.ImageKey = "add_user.png";
            this.addUserTabPage.Location = new System.Drawing.Point(4, 39);
            this.addUserTabPage.Name = "addUserTabPage";
            this.addUserTabPage.Size = new System.Drawing.Size(1186, 690);
            this.addUserTabPage.TabIndex = 12;
            this.addUserTabPage.Text = "Add User";
            this.addUserTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.materialCard1);
            this.settingsTabPage.ImageKey = "settings.png";
            this.settingsTabPage.Location = new System.Drawing.Point(4, 39);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(1186, 690);
            this.settingsTabPage.TabIndex = 5;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.darkThemeMaterialSwitch);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(73, 96);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(282, 130);
            this.materialCard1.TabIndex = 1;
            // 
            // darkThemeMaterialSwitch
            // 
            this.darkThemeMaterialSwitch.AutoSize = true;
            this.darkThemeMaterialSwitch.Checked = true;
            this.darkThemeMaterialSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkThemeMaterialSwitch.Depth = 0;
            this.darkThemeMaterialSwitch.Location = new System.Drawing.Point(56, 47);
            this.darkThemeMaterialSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.darkThemeMaterialSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.darkThemeMaterialSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkThemeMaterialSwitch.Name = "darkThemeMaterialSwitch";
            this.darkThemeMaterialSwitch.Ripple = true;
            this.darkThemeMaterialSwitch.Size = new System.Drawing.Size(144, 37);
            this.darkThemeMaterialSwitch.TabIndex = 0;
            this.darkThemeMaterialSwitch.Text = "Dark Theme";
            this.darkThemeMaterialSwitch.UseVisualStyleBackColor = true;
            this.darkThemeMaterialSwitch.CheckedChanged += new System.EventHandler(this.darkThemeMaterialSwitch_CheckedChanged);
            // 
            // logoutTabPage
            // 
            this.logoutTabPage.Controls.Add(this.materialCard2);
            this.logoutTabPage.ImageKey = "logout.png";
            this.logoutTabPage.Location = new System.Drawing.Point(4, 74);
            this.logoutTabPage.Name = "logoutTabPage";
            this.logoutTabPage.Size = new System.Drawing.Size(1186, 655);
            this.logoutTabPage.TabIndex = 7;
            this.logoutTabPage.Text = "Logout";
            this.logoutTabPage.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.logoutMaterialButton);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(73, 96);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(282, 130);
            this.materialCard2.TabIndex = 2;
            // 
            // logoutMaterialButton
            // 
            this.logoutMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutMaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logoutMaterialButton.Depth = 0;
            this.logoutMaterialButton.HighEmphasis = true;
            this.logoutMaterialButton.Icon = global::task_management.Properties.Resources.logout;
            this.logoutMaterialButton.Location = new System.Drawing.Point(89, 47);
            this.logoutMaterialButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logoutMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logoutMaterialButton.Name = "logoutMaterialButton";
            this.logoutMaterialButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logoutMaterialButton.Size = new System.Drawing.Size(110, 36);
            this.logoutMaterialButton.TabIndex = 3;
            this.logoutMaterialButton.Text = "Log out";
            this.logoutMaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logoutMaterialButton.UseAccentColor = false;
            this.logoutMaterialButton.UseVisualStyleBackColor = true;
            this.logoutMaterialButton.Click += new System.EventHandler(this.logoutMaterialButton_Click);
            // 
            // exitTabPage
            // 
            this.exitTabPage.Controls.Add(this.materialCard3);
            this.exitTabPage.ImageKey = "exit.png";
            this.exitTabPage.Location = new System.Drawing.Point(4, 74);
            this.exitTabPage.Name = "exitTabPage";
            this.exitTabPage.Size = new System.Drawing.Size(1186, 655);
            this.exitTabPage.TabIndex = 8;
            this.exitTabPage.Text = "Exit";
            this.exitTabPage.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.exitMaterialButton);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(73, 96);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(282, 130);
            this.materialCard3.TabIndex = 3;
            // 
            // exitMaterialButton
            // 
            this.exitMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitMaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitMaterialButton.Depth = 0;
            this.exitMaterialButton.HighEmphasis = true;
            this.exitMaterialButton.Icon = global::task_management.Properties.Resources.exit;
            this.exitMaterialButton.Location = new System.Drawing.Point(104, 47);
            this.exitMaterialButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitMaterialButton.Name = "exitMaterialButton";
            this.exitMaterialButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exitMaterialButton.Size = new System.Drawing.Size(80, 36);
            this.exitMaterialButton.TabIndex = 3;
            this.exitMaterialButton.Text = "Exit";
            this.exitMaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exitMaterialButton.UseAccentColor = false;
            this.exitMaterialButton.UseVisualStyleBackColor = true;
            this.exitMaterialButton.Click += new System.EventHandler(this.exitMaterialButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tasks.png");
            this.imageList1.Images.SetKeyName(1, "projects.png");
            this.imageList1.Images.SetKeyName(2, "task_assignments.png");
            this.imageList1.Images.SetKeyName(3, "comments.png");
            this.imageList1.Images.SetKeyName(4, "settings.png");
            this.imageList1.Images.SetKeyName(5, "add.png");
            this.imageList1.Images.SetKeyName(6, "logout.png");
            this.imageList1.Images.SetKeyName(7, "exit.png");
            this.imageList1.Images.SetKeyName(8, "add_comment.png");
            this.imageList1.Images.SetKeyName(9, "add_project.png");
            this.imageList1.Images.SetKeyName(10, "add_task_assignment.png");
            this.imageList1.Images.SetKeyName(11, "add_user.png");
            this.imageList1.Images.SetKeyName(12, "user.png");
            this.imageList1.Images.SetKeyName(13, "users.png");
            // 
            // userTabPage
            // 
            this.userTabPage.ImageKey = "user.png";
            this.userTabPage.Location = new System.Drawing.Point(4, 74);
            this.userTabPage.Name = "userTabPage";
            this.userTabPage.Size = new System.Drawing.Size(1186, 655);
            this.userTabPage.TabIndex = 13;
            this.userTabPage.Text = "User";
            this.userTabPage.UseVisualStyleBackColor = true;
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
            this.projectsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).EndInit();
            this.addProjectTabPage.ResumeLayout(false);
            this.addProjectTabPage.PerformLayout();
            this.settingsTabPage.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.logoutTabPage.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.exitTabPage.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton cancelTaskButton;
        private MaterialSkin.Controls.MaterialButton saveTaskButton;
        private System.Windows.Forms.TabPage logoutTabPage;
        private System.Windows.Forms.TabPage exitTabPage;
        private System.Windows.Forms.TabPage addProjectTabPage;
        private System.Windows.Forms.TabPage addTaskAssignmentTabPage;
        private System.Windows.Forms.TabPage addCommentTabPage;
        private System.Windows.Forms.TabPage addUserTabPage;
        private MaterialSkin.Controls.MaterialButton deleteProjectButton;
        private MaterialSkin.Controls.MaterialButton editProjectButton;
        private MaterialSkin.Controls.MaterialButton addNewProjectButton;
        private MaterialSkin.Controls.MaterialButton searchProjectButton;
        private MaterialSkin.Controls.MaterialTextBox2 projectSearchTextBox;
        private MaterialSkin.Controls.MaterialLabel projectSearchLabel;
        private System.Windows.Forms.DataGridView projectDataGridView;
        private MaterialSkin.Controls.MaterialButton cancelProjectButton;
        private MaterialSkin.Controls.MaterialButton saveProjectButton;
        private System.Windows.Forms.DateTimePicker projectStartDateTimePicker;
        private MaterialSkin.Controls.MaterialLabel projectStartDateLabel;
        private MaterialSkin.Controls.MaterialLabel projectDescriptionLabel;
        private MaterialSkin.Controls.MaterialTextBox2 projectDescriptionTextBox;
        private MaterialSkin.Controls.MaterialLabel projectNameLabel;
        private MaterialSkin.Controls.MaterialTextBox2 projectNameTextBox;
        private MaterialSkin.Controls.MaterialLabel projectIDLabel;
        private MaterialSkin.Controls.MaterialTextBox2 projectIDTextBox;
        private System.Windows.Forms.DateTimePicker projectEndDateTimePicker;
        private MaterialSkin.Controls.MaterialLabel projectEndDateLabel;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialSwitch darkThemeMaterialSwitch;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton logoutMaterialButton;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton exitMaterialButton;
        private System.Windows.Forms.TabPage userTabPage;
    }
}