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
using task_management.Models;
using task_management.Presenters;
using task_management.Views;
using task_management._Repositories;
using MaterialSkin;
using System.Globalization;
using System.Configuration;

namespace task_management.Views
{
    public partial class MainView : MaterialForm, IMainView
    {
        // fields
        private MaterialSkinManager materialSkinManager;

        private String message;
        private bool isSuccessful;
        private bool isEdit;


        // constructor
        public MainView()
        {
            InitializeComponent();

            LoginView.getMaterialSkinManager().AddFormToManage(this);  // apply material skin manager to this form

            AssociateAndRaiseViewEvents();
        }





        // properties (task)
        public String Id
        {
            get { return taskIDTextBox.Text; }
            set { this.taskIDTextBox.Text = value; }
        }

        public String Name
        {
            get { return taskNameTextBox.Text; }
            set { this.taskNameTextBox.Text = value; }
        }

        public String Description
        {
            get { return taskDescriptionTextBox.Text; }
            set { this.taskDescriptionTextBox.Text = value; }
        }

        public String DueDate
        {
            get { return dueDateTimePicker.Value.ToString(); }
            set
            {
                DateTime parsedDate;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    this.dueDateTimePicker.Value = parsedDate;
                }
                else
                {
                    // Handle invalid DateTime format
                    // You can display an error message or take appropriate actions here
                }
            }
        }

        public String Priority
        {
            get { return taskPriorityTextBox.Text; }
            set { this.taskPriorityTextBox.Text = value; }
        }

        public String Status
        {
            get { return taskStatusTextBox.Text; }
            set { this.taskStatusTextBox.Text = value; }
        }

        public String ProjectId
        {
            get { return taskProjectIDTextBox.Text; }
            set { this.taskProjectIDTextBox.Text = value; }
        }

        public String SearchValue
        {
            get { return taskSearchTextBox.Text; }
            set { taskSearchTextBox.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { this.isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { this.isSuccessful = value; }
        }

        public String Message
        {
            get { return message; }
            set { this.message = value; }
        }



        // properties (project)
        public string ProjectID 
        {
            get { return projectIDTextBox.Text; }
            set { this.projectIDTextBox.Text = value; }
        }

        public string ProjectName 
        {
            get { return projectNameTextBox.Text; }
            set { this.projectNameTextBox.Text = value; }
        }

        public string ProjectDescription 
        {
            get { return projectDescriptionTextBox.Text; }
            set { this.projectDescriptionTextBox.Text = value; }
        }
        
        public string StartDate 
        {
            get { return projectStartDateTimePicker.Value.ToString(); }
            set
            {
                DateTime parsedDate;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    this.projectStartDateTimePicker.Value = parsedDate;
                }
                else
                {
                    // Handle invalid DateTime format
                    // You can display an error message or take appropriate actions here
                }
            }
        }

        public string EndDate
        {
            get { return projectEndDateTimePicker.Value.ToString(); }
            set
            {
                DateTime parsedDate;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    this.projectEndDateTimePicker.Value = parsedDate;
                }
                else
                {
                    // Handle invalid DateTime format
                    // You can display an error message or take appropriate actions here
                }
            }
        }

        public string SearchProjectValue 
        {
            get { return projectSearchTextBox.Text; }
            set { projectSearchTextBox.Text = value; }
        }


        // events (properties)
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public event EventHandler SearchProjectEvent;
        public event EventHandler AddNewProjectEvent;
        public event EventHandler EditProjectEvent;
        public event EventHandler DeleteProjectEvent;
        public event EventHandler SaveProjectEvent;
        public event EventHandler CancelProjectEvent;


        // methods
        private void MainView_Load(object sender, EventArgs e)
        {

        }


        private void AssociateAndRaiseViewEvents()
        {
            // associate events with event handlers

            //
            // TASKS
            //


            // search
            searchTaskButton.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };  // raise search event

            taskSearchTextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;   // Prevents the Enter key from being processed further
                    e.SuppressKeyPress = true;  // supresses the key press

                    SearchEvent?.Invoke(this, EventArgs.Empty);  // raise search event
                }
            };

            // add new
            addNewTaskButton.Click += delegate {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                materialTabControl1.SelectTab(addEditTaskTabPage);  // switch to Add/Edit tab
            };  // raise add new event

            // edit
            editTaskButton.Click += delegate { 
                EditEvent?.Invoke(this, EventArgs.Empty);

                materialTabControl1.SelectTab(addEditTaskTabPage);  // switch to Add/Edit tab
            };  // raise edit event

            // delete
            deleteTaskButton.Click += delegate { 

                var result = MessageBox.Show("Are you sure you want to delete the selected task ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  // show message
            
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);  // show message
                }
            
            };  // raise delete event

            // save
            saveTaskButton.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    materialTabControl1.SelectTab(0);  // switch to Main (Task) View tab
                }

                MessageBox.Show(message);  // show message
            };  // raise save event

            // cancel
            cancelTaskButton.Click += delegate { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
            
            };  // raise cancel event



            //
            // PROJECTS
            //

            // search
            searchProjectButton.Click += delegate { SearchProjectEvent?.Invoke(this, EventArgs.Empty); };  // raise search event

            projectSearchTextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;   // Prevents the Enter key from being processed further
                    e.SuppressKeyPress = true;  // supresses the key press

                    SearchProjectEvent?.Invoke(this, EventArgs.Empty);  // raise search event
                }
            };

            // add new
            addNewProjectButton.Click += delegate {
                AddNewProjectEvent?.Invoke(this, EventArgs.Empty);
                materialTabControl1.SelectTab(addProjectTabPage);  // switch to Add/Edit tab
            };  // raise add new event

            // edit
            editProjectButton.Click += delegate {
                EditProjectEvent?.Invoke(this, EventArgs.Empty);

                materialTabControl1.SelectTab(addProjectTabPage);  // switch to Add/Edit tab
            };  // raise edit event

            // delete
            deleteProjectButton.Click += delegate {

                var result = MessageBox.Show("Are you sure you want to delete the selected project ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  // show message

                if (result == DialogResult.Yes)
                {
                    DeleteProjectEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);  // show message
                }

            };  // raise delete event

            // save
            saveProjectButton.Click += delegate {
                SaveProjectEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    materialTabControl1.SelectTab(projectsTabPage);  // switch to Project View tab
                }

                MessageBox.Show(message);  // show message
            };  // raise save event

            // cancel
            cancelTaskButton.Click += delegate {
                CancelProjectEvent?.Invoke(this, EventArgs.Empty);

            };  // raise cancel event

        }


        public void SetTaskListBindingSource(BindingSource taskList)
        {
            taskDataGridView.DataSource = taskList;
        }

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

        public void SetProjectListBindingSource(BindingSource projectList)
        {
            projectDataGridView.DataSource = projectList;
        }

        private void darkThemeMaterialSwitch_CheckedChanged(object sender, EventArgs e)
        {
            LoginView.getMaterialSkinManager().Theme = darkThemeMaterialSwitch.Checked ? MaterialSkin.MaterialSkinManager.Themes.DARK : MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void logoutMaterialButton_Click(object sender, EventArgs e)
        {

            IMainView mainView = MainView.GetInstance();
            ILoginView loginView = LoginView.GetInstance();
            IMainRepository mainRepository = new MainRepository(ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString);
            new MainPresenter(mainView, mainRepository);

            ((Form)loginView).Show();
            ((Form)mainView).Hide();
        }

        // Singleton pattern (only one instance of this view/form is allowed)
        private static MainView instance = null;    // singleton instance
        public static MainView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MainView();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;

                instance.BringToFront();
            }

            return instance;
        }

        private void exitMaterialButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
