using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectISS.Model;
using ProiectISS.Repository;

namespace ProiectISS.Service
{
    public class Services
    {
        private EmployeeRepository repoEmployee;
        private BugRepository repoBug;

        public Services(EmployeeRepository repoEmployee, BugRepository repoBug)
        {
            this.repoEmployee = repoEmployee;
            this.repoBug = repoBug;
        }

        public List<Employee> getAccounts()
        {
            return repoEmployee.getAccounts();
        }

        public List<Bug> getBugs()
        {
            return repoBug.getBugs();
        }

        public void addAccount(String username, String password, String firstName, String lastName, EmployeeType type)
        {
            repoEmployee.addAccount(new Employee(username, password, firstName, lastName, type));
        }

        public void deleteAccount(String username)
        {
            repoEmployee.deleteAccount(username);
        }

        public void updateAccount(String username, String password, String firstName, String lastName, EmployeeType type)
        {
            repoEmployee.updateAccount(new Employee(username, password, firstName, lastName, type));
        }

        public Employee getAccount(String username, String password)
        {
            return repoEmployee.getAccount(username, password);
        }
    }
}
