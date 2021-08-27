using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    public class Tasks
    {
        public ObservableCollection<Task> TaskList = new ObservableCollection<Task>();
        public Tasks()
        {

        }
    }
}
