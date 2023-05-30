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

            SetCustomFormatForDateTimePicker();     // set custom format for due date time picker

            AssociateAndRaiseViewEvents();
        }





        // properties
        public int Id
        {
            get { return int.Parse(taskIDTextBox.Text); }
            set { taskIDTextBox.Text = value.ToString(); }
        }

        public String Description
        {
            get { return taskDescriptionTextBox.Text; }
            set { taskIDTextBox.Text = value; }
        }

        public DateTime DueDate
        {
            get { return dueDateTimePicker.Value; }
            set { dueDateTimePicker.Value = value; }
        }

        public String Priority
        {
            get { return taskPriorityTextBox.Text; }
            set { taskPriorityTextBox.Text = value; }
        }

        public String Status
        {
            get { return taskStatusTextBox.Text; }
            set { taskStatusTextBox.Text = value; }
        }

        public int ProjectId
        {
            get { return int.Parse(taskProjectIDTextBox.Text); }
            set { this.taskProjectIDTextBox.Text = value.ToString(); }
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


        // events (properties)
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;


        // methods
        private void MainView_Load(object sender, EventArgs e)
        {

        }


        private void AssociateAndRaiseViewEvents()
        {
            // associate events with event handlers
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

            // TODO: ADD, EDIT, DELETE
        }


        private void SetCustomFormatForDateTimePicker()
        {
            dueDateTimePicker.Format = DateTimePickerFormat.Custom;
            dueDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss";
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

        
    }
}
