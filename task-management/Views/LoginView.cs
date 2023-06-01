using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_management.Views
{
    public partial class LoginView : MaterialForm, ILoginView
    {
        // fields
        private static MaterialSkinManager materialSkinManager;

        


        // constructor
        public LoginView()
        {
            InitializeComponent();

            InitMaterialSkinManager();

            AssociateAndRaiseViewEvents();
        }
        
        // properties (events)
        public event EventHandler Login;
        public event EventHandler Register;
        public event EventHandler HideShowPassword;

        public string Username 
        { 
            get { return usernameTextBox.Text; }
            set { usernameTextBox.Text = value; }
        }

        public string Password 
        {
            get { return passwordTextBox.Text; }
            set { passwordTextBox.Text = value; }
        }

        public bool HideShow 
        {
            get { return hideShowPasswordCheckbox.Checked; }
            set { hideShowPasswordCheckbox.Checked = value; }
        }

        public MaterialTextBox2 PasswordTextBox
        {
            get { return passwordTextBox; }
            set { passwordTextBox = value; }
        }

        public MaterialForm Form 
        {
            get { return this; }
        }

        public MaterialSkinManager MaterialSkinManager
        {
            get { return materialSkinManager; }
        }


        // methods

        // initialize material skin manager
        private void InitMaterialSkinManager()
        {
            
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;

            // Set the color scheme for the form
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900,
                Primary.Blue500, Accent.LightBlue700,
                TextShade.WHITE
            );

        }

        // get skin manager
        public static MaterialSkinManager getMaterialSkinManager()
        {
            return materialSkinManager;
        }

        // associate events with event handlers and raise events
        private void AssociateAndRaiseViewEvents()
        {
            // associate events with event handlers
            loginButton.Click += delegate { Login?.Invoke(this, EventArgs.Empty); };
            registerButton.Click += delegate { Register?.Invoke(this, EventArgs.Empty); };
            hideShowPasswordCheckbox.CheckedChanged += delegate { HideShowPassword?.Invoke(this, EventArgs.Empty); };
        }

        // load login view
        private void LoginView_Load(object sender, EventArgs e)
        {

        }



        // Singleton pattern (only one instance of this view/form is allowed)
        private static LoginView instance = null;    // singleton instance
        public static LoginView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LoginView();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;

                instance.BringToFront();
            }

            return instance;
        }
    }
}
