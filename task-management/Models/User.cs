using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_management.Models
{
    public class User
    {
        // fields / members
        private int id;
        private String username;
        private String password;

        // properties (+ validation)
        [DisplayName("User ID")]
        public int Id { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "User Name is required !")]
        [StringLength(32, MinimumLength = 3, ErrorMessage = "User Name must be between 3 and 32 characters !")]
        public String Username { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required !")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Task Description must be between 8 and 32 characters !")]
        public String Password { get; set; }

        // constructors
        public User() { }

        public User(int id, String username, String password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }
    }
}
