using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_management.Views
{
    public interface IMainView
    {

        // properties (events)
        event EventHandler ShowTaskView;
        event EventHandler ShowTaskAssignmentView;
        event EventHandler ShowProjectView;
        event EventHandler ShowCommentView;

    }
}
