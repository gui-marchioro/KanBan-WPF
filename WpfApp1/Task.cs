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
        public string State { get; set; }

        public override string ToString()
        {
            // return base.ToString();
            return string.Format("{0}", Name);
        }

        public Task(string name)
        {
            this.Name = name;
            this.Priority = 1;
            this.State = "Not Started";
        }
        public Task(string name, int priority)
        {
            this.Name = name;
            this.Priority = priority;
            this.State = "Not Started";
        }
        public Task(string name, int priority, string description)
        {
            this.Name = name;
            this.Priority = priority;
            this.Description = description;
            this.State = "Not Started";
        }
    }
}
