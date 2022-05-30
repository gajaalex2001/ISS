using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectISS.Model;
using System.Data;
using Dapper;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace ProiectISS.Repository
{
    public class EmployeeRepository
    {
        IDictionary<String, string> props;

        public EmployeeRepository(IDictionary<string, string> props)
        {
            this.props = props;
        }

        public List<Employee> getAccounts()
        {
            using (IDbConnection con = DBUtils.getConnection(props))
            {
                string queryString = "Select * from Employee";

                try
                {
                    List<Employee> results = con.Query<Employee>(queryString).ToList();
                    return results;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error db" + e);
                }
            }

            return null;
        }

        public void addAccount(Employee employee)
        {
            using (IDbConnection con = DBUtils.getConnection(props))
            {
                string queryString = "insert into Employee(username, password, firstName, lastName, type) values (@username, @password, @firstName, @lastName, @type)";

                try
                {
                    con.Execute(queryString, new { 
                        username = employee.username, 
                        password = employee.password,
                        firstName = employee.firstName,
                        lastName = employee.lastName,
                        type = employee.type
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error db" + e);
                }
            }
        }

        public void deleteAccount(String username)
        {
            using (IDbConnection con = DBUtils.getConnection(props))
            {
                string queryString = "delete from Employee where username=@id";

                try
                {
                    con.Execute(queryString, new
                    {
                        id = username
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error db" + e);
                }
            }
        }

        public void updateAccount(Employee employee)
        {
            using (IDbConnection con = DBUtils.getConnection(props))
            {
                string queryString = "Update Employee Set password = @pass, firstName = @fName, lastName = @lName, type = @type where username = @username";

                try
                {
                    con.Execute(queryString, new
                    {
                        username = employee.username,
                        pass = employee.password,
                        fName = employee.firstName,
                        lName = employee.lastName,
                        type = employee.type
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error db" + e);
                }
            }
        }

        public Employee getAccount(String username, String password)
        {

            using (IDbConnection con = DBUtils.getConnection(props))
            {
                string queryString = "select * from Employee where username=@user and password=@pass";

                try
                {
                    List<Employee> e = con.Query<Employee>(queryString, new {user = username, pass = password }).ToList();

                    if (e.Count() == 0) return null;
                    else return e.ElementAt(0);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error db" + e);
                }
            }

            return null;
        }
    }
}
