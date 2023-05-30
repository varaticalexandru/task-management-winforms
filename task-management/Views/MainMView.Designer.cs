namespace task_management.Views
{
    partial class MainMView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMView));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tasksTabPage = new System.Windows.Forms.TabPage();
            this.projectsTabPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.taskAssignmentsTabPage = new System.Windows.Forms.TabPage();
            this.commentsTabPage = new System.Windows.Forms.TabPage();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tasksTabPage);
            this.materialTabControl1.Controls.Add(this.projectsTabPage);
            this.materialTabControl1.Controls.Add(this.taskAssignmentsTabPage);
            this.materialTabControl1.Controls.Add(this.commentsTabPage);
            this.materialTabControl1.Controls.Add(this.usersTabPage);
            this.materialTabControl1.Controls.Add(this.settingsTabPage);
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
            this.tasksTabPage.ImageKey = "tasks.png";
            this.tasksTabPage.Location = new System.Drawing.Point(4, 39);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tasksTabPage.Size = new System.Drawing.Size(1186, 690);
            this.tasksTabPage.TabIndex = 0;
            this.tasksTabPage.Text = "Tasks";
            this.tasksTabPage.UseVisualStyleBackColor = true;
            // 
            // projectsTabPage
            // 
            this.projectsTabPage.ImageKey = "projects.png";
            this.projectsTabPage.Location = new System.Drawing.Point(4, 39);
            this.projectsTabPage.Name = "projectsTabPage";
            this.projectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectsTabPage.Size = new System.Drawing.Size(1186, 690);
            this.projectsTabPage.TabIndex = 1;
            this.projectsTabPage.Text = "Projects";
            this.projectsTabPage.UseVisualStyleBackColor = true;
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
            // MainMView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "MainMView";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management";
            this.materialTabControl1.ResumeLayout(false);
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
    }
}