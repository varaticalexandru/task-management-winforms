using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_management.Models
{
    public interface ILoginRepository
    {
        // methods
        Boolean? Login(String username, String password);
        Boolean? Register(String username, String password);
    }
}
