using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectISS.Model
{
    public class Employee
    {
        private String username;
        private String password;
        private String firstName;
        private String lastName;
        private EmployeeType type;

        public Employee(string username, string password, string firstName, string lastName, EmployeeType type)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.type = type;
        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public EmployeeType Type
        {
            get { return type; }
            set { type = value; }
        }


    }
}
