using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    public class Project
    {
        public ObservableCollection<Task> ListNotStarted = new ObservableCollection<Task>();
        public ObservableCollection<Task> ListInProgress = new ObservableCollection<Task>();
        public ObservableCollection<Task> ListCompleted = new ObservableCollection<Task>();


        public Project()
        {

        }

        public void ChangeTaskState(Task task, Task.State newState)
        {
            switch (task.CurrentState)
            {
                case Task.State.notStarted:
                    ListNotStarted.Remove(task);
                    break;
                case Task.State.inProgress:
                    ListInProgress.Remove(task);
                    break;
                case Task.State.completed:
                    ListCompleted.Remove(task);
                    break;
            }

            task.CurrentState = newState;
            switch (task.CurrentState)
            {
                case Task.State.notStarted:
                    ListNotStarted.Add(task);
                    break;
                case Task.State.inProgress:
                    ListInProgress.Add(task);
                    break;
                case Task.State.completed:
                    ListCompleted.Add(task);
                    break;
            }
        }
    }
}
