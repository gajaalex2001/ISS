using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectISS.Model
{
    public class Bug
    {
        private int id;
        private String description;
        private Severity severity;
        private Priority priority;

        public Bug(int id, string description, Severity severity, Priority priority)
        {
            this.id = id;
            this.description = description;
            this.severity = severity;
            this.priority = priority;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public Severity Severity
        {
            get { return severity; }
            set { severity = value; }
        }

        public Priority Priority
        {
            get { return priority; }
            set { priority = value; }
        }
    }
}
