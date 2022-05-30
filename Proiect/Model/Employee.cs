using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace ProiectISS.Model
{
    public class Employee
    {
        [Key]
        public String username { get; set; }
        public String password { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public EmployeeType type { get; set; }

        public Employee(string username, string password, string firstName, string lastName, EmployeeType type)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.type = type;
        }
    }
}
