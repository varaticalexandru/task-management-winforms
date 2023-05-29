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
        MaterialSkin.MaterialSkinManager materialSkinManager;


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


        // methods
        private void InitMaterialSkinManager()
        {
            
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;

            // Set the color scheme for the form
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

        }
        
        private void AssociateAndRaiseViewEvents()
        {
            /*loginButton.Click += delegate { Login?.Invoke(this, EventArgs.Empty); };
            registerButton.Click += delegate { Register?.Invoke(this, EventArgs.Empty); };*/
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
