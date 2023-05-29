namespace task_management.Views
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.hideShowPasswordCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.usernameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.registerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.registerButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hideShowPasswordCheckbox
            // 
            this.hideShowPasswordCheckbox.AutoSize = true;
            this.hideShowPasswordCheckbox.Depth = 0;
            this.hideShowPasswordCheckbox.Location = new System.Drawing.Point(536, 345);
            this.hideShowPasswordCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.hideShowPasswordCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.hideShowPasswordCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.hideShowPasswordCheckbox.Name = "hideShowPasswordCheckbox";
            this.hideShowPasswordCheckbox.ReadOnly = false;
            this.hideShowPasswordCheckbox.Ripple = true;
            this.hideShowPasswordCheckbox.Size = new System.Drawing.Size(196, 37);
            this.hideShowPasswordCheckbox.TabIndex = 2;
            this.hideShowPasswordCheckbox.Text = "Show / Hide Password";
            this.hideShowPasswordCheckbox.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = false;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(658, 405);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(128, 36);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AnimateReadOnly = false;
            this.passwordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.ErrorMessage = "Wrong password";
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.HideSelection = true;
            this.passwordTextBox.Hint = "Password";
            this.passwordTextBox.LeadingIcon = null;
            this.passwordTextBox.LeaveOnEnterKey = true;
            this.passwordTextBox.Location = new System.Drawing.Point(536, 259);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.PrefixSuffixText = null;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(250, 48);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TrailingIcon = global::task_management.Properties.Resources.password;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.AnimateReadOnly = false;
            this.usernameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameTextBox.Depth = 0;
            this.usernameTextBox.ErrorMessage = "Wrong username";
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameTextBox.HideSelection = true;
            this.usernameTextBox.Hint = "Username";
            this.usernameTextBox.LeadingIcon = null;
            this.usernameTextBox.LeaveOnEnterKey = true;
            this.usernameTextBox.Location = new System.Drawing.Point(536, 173);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PrefixSuffixText = null;
            this.usernameTextBox.ReadOnly = false;
            this.usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionLength = 0;
            this.usernameTextBox.SelectionStart = 0;
            this.usernameTextBox.ShortcutsEnabled = true;
            this.usernameTextBox.Size = new System.Drawing.Size(250, 48);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.TabStop = false;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTextBox.TrailingIcon = global::task_management.Properties.Resources.username;
            this.usernameTextBox.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(536, 460);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(250, 1);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Depth = 0;
            this.registerLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registerLabel.Location = new System.Drawing.Point(543, 492);
            this.registerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(94, 19);
            this.registerLabel.TabIndex = 6;
            this.registerLabel.Text = "No account ?";
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = false;
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.BackColor = System.Drawing.Color.White;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registerButton.Depth = 0;
            this.registerButton.HighEmphasis = false;
            this.registerButton.Icon = null;
            this.registerButton.Location = new System.Drawing.Point(658, 482);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registerButton.Size = new System.Drawing.Size(128, 36);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Register";
            this.registerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.registerButton.UseAccentColor = false;
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.hideShowPasswordCheckbox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management | Authentification";
            this.Load += new System.EventHandler(this.LoginView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 usernameTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextBox;
        private MaterialSkin.Controls.MaterialCheckbox hideShowPasswordCheckbox;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel registerLabel;
        private MaterialSkin.Controls.MaterialButton registerButton;
    }
}