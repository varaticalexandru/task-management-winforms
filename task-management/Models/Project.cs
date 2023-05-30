using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace task_management.Models
{
    public class Project
    {
        // fields / members
        private int id;
        private String name;
        private String projectDescription;
        private DateTime startDate;
        private DateTime endDate;

        // properties (+ validation)
        [DisplayName("Project ID")]
        public int Id { get; set; }

        [DisplayName("Project Name")]
        [Required(ErrorMessage = "Project Name is required !")]
        [StringLength(45, MinimumLength = 3, ErrorMessage = "Project Name must be between 3 and 45 characters !")]
        public String Name { get; set; }

        [DisplayName("Project Description")]
        [Required(ErrorMessage = "Project Description is required !")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Project Description must be between 3 and 100 characters !")]
        public String Description { get; set; }

        [DisplayName("Start Date")]
        [Required(ErrorMessage = "Start Date is required !")]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        [Required(ErrorMessage = "End Date is required !")]
        public DateTime EndDate { get; set; }


    }
}
