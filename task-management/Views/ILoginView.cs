using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_management.Views
{
    public interface ILoginView
    {
        // properties (events)
        event EventHandler Login;
        event EventHandler Register;
        event EventHandler HideShowPassword;
    
        // methods
        
    }
}
