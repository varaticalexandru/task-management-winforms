using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task_management.Models;
using task_management.Views;

namespace task_management.Presenters
{
    public class MainPresenter
    {
        // fields
        private IMainView view;
        private IMainRepository repository;
        private BindingSource taskBindingSource;
        private BindingSource projectBindingSource;
        private IEnumerable<Models.Task> taskList;
        private IEnumerable<Models.Project> projectList;

        

        // constructor
        public MainPresenter(IMainView view, IMainRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.taskBindingSource = new BindingSource();
            this.projectBindingSource = new BindingSource();

            this.taskList = repository.GetAllTasks();
            this.taskBindingSource.DataSource = taskList;  // set data source

            this.projectList = repository.GetAllProjects();
            this.projectBindingSource.DataSource = projectList;  // set data source

            // associate view events with presenter methods
            this.view.SearchEvent += SearchTask;
            this.view.AddNewEvent += AddNewTask;
            this.view.EditEvent += EditTask;
            this.view.EditEvent += LoadSelectedTaskToEdit;
            this.view.DeleteEvent += DeleteTask;
            this.view.SaveEvent += SaveTask;
            this.view.CancelEvent += CancelTask;

            this.view.SearchProjectEvent += SearchProject;
            this.view.AddNewProjectEvent += AddNewProject;
            this.view.EditProjectEvent += EditProject;
            this.view.EditProjectEvent += LoadSelectedProjectToEdit;
            this.view.DeleteProjectEvent += DeleteProject;
            this.view.SaveProjectEvent += SaveProject;
            this.view.CancelProjectEvent += CancelProject;

            // set tasks binding source
            this.view.SetTaskListBindingSource(taskBindingSource);

            // set projects binding source
            this.view.SetProjectListBindingSource(projectBindingSource);

            // load task list view
            LoadTaskList();

            // load project list view
            LoadProjectList();

            // show view
            this.view.Show();
        }

        


        // methods

        // load task list
        private void LoadTaskList()
        {
            taskList = repository.GetAllTasks();
            taskBindingSource.DataSource = taskList;

        }

        // load project list
        private void LoadProjectList()
        {
            projectList = repository.GetAllProjects();
            projectBindingSource.DataSource = projectList;
        }

        // search task
        private void SearchTask(object sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(view.SearchValue);
            if (!emptyValue)
            {
                taskList = repository.GetByValueTask(view.SearchValue);
            }
            else
            {
                taskList = repository.GetAllTasks();
            }

            taskBindingSource.DataSource = taskList;
        }

        // search project
        private void SearchProject(object sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(view.SearchProjectValue);
            if (!emptyValue)
            {
                projectList = repository.GetByValueProject(view.SearchProjectValue);
            }
            else
            {
                projectList = repository.GetAllProjects();
            }

            projectBindingSource.DataSource = projectList;
        }

        // cancel task
        private void CancelTask(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        // cancel project
        private void CancelProject(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        // save task
        private void SaveTask(object sender, EventArgs e)
        {
            var model= new Models.Task();

            // check if id is empty
            if (!String.IsNullOrEmpty(view.Id))
                model.Id = Convert.ToInt32(view.Id);
            else
                model.Id = -1;


            model.Name = view.Name;
            model.Description = view.Description;
            model.DueDate = DateTime.Parse(view.DueDate.Substring(0, view.DueDate.Length - 3));
            model.Priority = view.Priority;
            model.Status = view.Status;

            // check if project id is empty
            if (!String.IsNullOrEmpty(view.ProjectId))
                model.ProjectId = Convert.ToInt32(view.ProjectId);
            else
                model.ProjectId = -1;


            try
            {
                // validate model
                new Common.TaskValidation().Validate(model);

                if (view.IsEdit)    // edit task
                {
                    repository.EditTask(model);
                    view.Message = "Task updated successfully";
                }
                else    // add task
                {
                    repository.AddTask(model);
                    view.Message = "Task added successfully";
                }

                view.IsSuccessful = true;
                LoadTaskList();     // reload task list
                CleanViewFields();  // clean view fields
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;

            }
        }

        // save project
        private void SaveProject(object sender, EventArgs e)
        {
            var model = new Models.Project();

            // check if id is empty
            if (!String.IsNullOrEmpty(view.ProjectID))
                model.Id = Convert.ToInt32(view.ProjectID);
            else
                model.Id = -1;


            model.Name = view.ProjectName;
            model.Description = view.ProjectDescription;
            model.StartDate = DateTime.Parse(view.StartDate.Substring(0, view.StartDate.Length - 3));
            model.EndDate = DateTime.Parse(view.EndDate.Substring(0, view.EndDate.Length - 3));

            try
            {
                // validate model
                new Common.TaskValidation().Validate(model);

                if (view.IsEdit)    // edit task
                {
                    repository.EditProject(model);
                    view.Message = "Project updated successfully";
                }
                else    // add task
                {
                    repository.AddProject(model);
                    view.Message = "Project added successfully";
                }

                view.IsSuccessful = true;
                LoadProjectList();     // reload task list
                CleanViewFieldsProject();  // clean view fields
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;

            }
        }

        // clean view fields for task
        private void CleanViewFields()
        {
            view.Id = "0";
            view.Name = "";
            view.Description = "";
            view.DueDate = "";
            view.Priority = "";
            view.Status = "";
            view.ProjectId = "0";
        }

        // clean view fields for project
        private void CleanViewFieldsProject()
        {
            view.ProjectID = "0";
            view.ProjectName = "";
            view.ProjectDescription = "";
            view.StartDate = "";
            view.EndDate = "";
        }

        // delete task
        private void DeleteTask(object sender, EventArgs e)
        {
            try
            {
                var task = (Models.Task)taskBindingSource.Current;
                repository.DeleteTask(task.Id);
                view.Message = "Task deleted successfully";
                view.IsSuccessful = true;
                LoadTaskList();     // reload task list
                CleanViewFields();  // clean view fields
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete task";
            }
        }

        // delete project
        private void DeleteProject(object sender, EventArgs e)
        {
            try
            {
                var project = (Models.Project)projectBindingSource.Current;
                repository.DeleteProject(project.Id);
                view.Message = "Project deleted successfully";
                view.IsSuccessful = true;
                LoadProjectList();     // reload project list
                CleanViewFieldsProject();  // clean view fields
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete project";
            }
        }

        // edit task
        private void EditTask(object sender, EventArgs e)
        {

        }

        // edit project
        private void EditProject(object sender, EventArgs e)
        {
            
        }

        // add task
        private void AddNewTask(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        // add project
        private void AddNewProject(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        // load selected project to edit
        private void LoadSelectedTaskToEdit(object sender, EventArgs e)
            {
            var task = (Models.Task)taskBindingSource.Current;

            // set view properties
            view.Id = task.Id.ToString();
            view.Name = task.Name;
            view.Description = task.Description;
            view.DueDate = task.DueDate.ToString();
            view.Priority = task.Priority;
            view.Status = task.Status;
            view.ProjectId = task.ProjectId.ToString();

            view.IsEdit = true;

        }

        // load selected project to edit
        private void LoadSelectedProjectToEdit(object sender, EventArgs e)
        {
            var project = (Models.Project)projectBindingSource.Current;

            // set view properties
            view.ProjectID = project.Id.ToString();
            view.ProjectName = project.Name;
            view.ProjectDescription = project.Description;
            view.StartDate = project.StartDate.ToString();
            view.EndDate = project.EndDate.ToString();

            view.IsEdit = true;

        }
    }
}
