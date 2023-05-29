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
    public partial class TaskView : Form, ITaskView
    {
        // fields
        private String message;
        private bool isSuccessful;
        private bool isEdit;

        // constructor
        public TaskView()
        {
            InitializeComponent();

            // set custom format for due date time picker
            dueDateTimePicker.Format = DateTimePickerFormat.Custom;
            dueDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss";

            // hide task detail tab page
            taskTabControl.TabPages.Remove(taskDetailTabPage);

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
            get { return isSuccessful;  }
            set { this.isSuccessful = value; }
        }

        public String Message 
        { 
            get { return message; }
            set { this.message = value; }
        }

        // events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // methods
        private void TaskView_Load(object sender, EventArgs e)
        {
            

        }


        public void SetTaskListBindingSource(BindingSource taskList)
        {
            taskDataGridView.DataSource = taskList;
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

    }
}
