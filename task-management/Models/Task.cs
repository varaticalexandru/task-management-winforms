using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace task_management.Models
{
    public class Task
    {
        // fields / members
        private int id;
        private String name;
        private String description;
        private DateTime dueDate;
        private String priority;
        private String status;
        private int projectId;


        // properties (+ validation)
        [DisplayName("Task ID")]
        public int Id { get; set; }

        [DisplayName("Task Name")]
        [Required(ErrorMessage = "Task Name is required !")]
        [StringLength(45, MinimumLength =3, ErrorMessage = "Task Name must be between 3 and 45 characters !")]
        public String Name { get; set; }

        [DisplayName("Task Description")]
        [Required(ErrorMessage = "Task Description is required !")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Task Description must be between 3 and 100 characters !")]
        public String Description { get; set; }

        [DisplayName("Due Date")]
        [Required(ErrorMessage = "Due Date is required !")]

        public DateTime DueDate { get; set; }

        [DisplayName("Priority")]
        [Required(ErrorMessage = "Priority is required !")]
        public String Priority { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "Status is required !")]
        public String Status { get; set; }

        [DisplayName("Project ID")]
        [Required(ErrorMessage = "Project ID is required !")]
        public int ProjectId { get; set; }


        // constructors
        public Task() { }

        public Task(int id, String name, String description, DateTime dueDate, String priority, String status, int projectId)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.dueDate = dueDate;
            this.priority = priority;
            this.status = status;
            this.projectId = projectId;
        }

    }
}
