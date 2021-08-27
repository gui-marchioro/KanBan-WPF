using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Task
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public enum State
        {
            notStarted,
            inProgress,
            completed
        }

        public State CurrentState { get; set; }

        public override string ToString()
        {
            // return base.ToString();
            return string.Format("{0}", Name);
        }

        public Task(string name)
        {
            this.Name = name;
            this.Priority = 1;
            this.CurrentState = State.notStarted;
        }
        public Task(string name, int priority)
        {
            this.Name = name;
            this.Priority = priority;
            this.CurrentState = State.notStarted;
        }
        public Task(string name, int priority, string description)
        {
            this.Name = name;
            this.Priority = priority;
            this.Description = description;
            this.CurrentState = State.notStarted;
        }
    }
}
