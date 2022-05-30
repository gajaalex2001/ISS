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
        private readonly IDictionary<String, IObserver> loggedProgrammers;

        public Services(EmployeeRepository repoEmployee, BugRepository repoBug)
        {
            this.repoEmployee = repoEmployee;
            this.repoBug = repoBug;
            loggedProgrammers = new Dictionary<String, IObserver>();
        }

        public List<Employee> getAccounts()
        {
            return repoEmployee.getAccounts();
        }

        public List<Bug> getBugs()
        {
            return repoBug.getBugs();
        }

        public void login(String username, IObserver programmer)
        {

            if (loggedProgrammers.ContainsKey(username))
            {
                throw new ServiceException("User already logged in");
            }

            loggedProgrammers.Add(username, programmer);
            Console.WriteLine(loggedProgrammers[username]);
        }

        public void logout(String username)
        {
            loggedProgrammers.Remove(username);
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

        public void addBug(String description, Priority prio, Severity seve)
        {
            repoBug.addBug(new Bug(0, description, seve, prio));
            foreach(String key in loggedProgrammers.Keys)
            {
                loggedProgrammers[key].updateReceived();
            }
        }

        public void fixBug(int id)
        {
            repoBug.fixBug(id);

            foreach (String key in loggedProgrammers.Keys)
            {
                loggedProgrammers[key].updateReceived();
            }
        }
    }
}
