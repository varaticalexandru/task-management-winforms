using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;

namespace task_management.Views
{
    public interface ILoginView
    {
        // properties
        String Username { get; set; }
        String Password { get; set; }
        bool HideShow { get; set; }
        MaterialTextBox2 PasswordTextBox { get; set; }
        MaterialForm Form { get; }

        // properties (events)
        event EventHandler Login;
        event EventHandler Register;
        event EventHandler HideShowPassword;
    
        // methods
        
    }
}
