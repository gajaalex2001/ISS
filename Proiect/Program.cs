using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectISS.Model;
using ProiectISS.Repository;
using System.Configuration;
using ProiectISS.Service;

namespace ProiectISS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Configuration Settings for bugsDB {0}", GetConnectionStringByName("bugsDB"));

            IDictionary<String, string> props = new SortedList<String, String>();
            props.Add("ConnectionString", GetConnectionStringByName("bugsDB"));

            EmployeeRepository repoEmployee = new EmployeeRepository(props);
            BugRepository repoBug = new BugRepository(props);
            Services srv = new Services(repoEmployee, repoBug);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginWindow(srv));
        }

        static string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}
