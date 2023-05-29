using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_management.Views;
using task_management.Models;
using System.Windows.Forms;

namespace task_management.Presenters
{
    public class TaskPresenter
    {
        // fields
        private ITaskView view;
        private ITaskRepository repository;
        private BindingSource taskBindingSource;
        private IEnumerable<Models.Task> taskList; 

        // constructor
        public TaskPresenter(ITaskView view, ITaskRepository repository)
        {


            this.view = view;
            this.repository = repository;
            this.taskBindingSource = new BindingSource();

            this.taskList = repository.GetAll();
            this.taskBindingSource.DataSource = taskList;  // set data source

            // associate view events with presenter methods
            this.view.SearchEvent += SearchTask;
            this.view.AddNewEvent += AddNewTask;
            this.view.EditEvent += EditTask;
            this.view.DeleteEvent += DeleteTask;
            this.view.SaveEvent += SaveTask;
            this.view.CancelEvent += CancelTask;

            // set tasks binding source
            this.view.SetTaskListBindingSource(taskBindingSource);

            // load task list view
            LoadTaskList();

            // show view
            this.view.Show();
        }

        private void LoadTaskList()
        {
            
        }

        private void SearchTask(object sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(view.SearchValue);
            if (!emptyValue)
            {
                taskList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                taskList = repository.GetAll();
            }

            this.taskBindingSource.DataSource = taskList;
        }

        private void CancelTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
