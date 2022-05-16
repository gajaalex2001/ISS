using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectISS.Model;
using System.Data;

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
            IDbConnection con = DBUtils.getConnection(props);
            List<Employee> employees = new List<Employee>();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT * from Employee";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        String username = dataR.GetString(0);
                        String password = dataR.GetString(1);
                        String firstName = dataR.GetString(2);
                        String lastName = dataR.GetString(3);
                        EmployeeType type = (EmployeeType)Enum.Parse(typeof(EmployeeType), dataR.GetString(4));

                        Employee e = new Employee(username,password,firstName,lastName,type);
                        employees.Add(e);
                    }
                }
            }

            return employees;
        }

        public void addAccount(Employee employee)
        {

            IDbConnection con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "insert into Employee  values (@username, @password, @firstName, @lastName, @type)";
                var paramUsername = comm.CreateParameter();
                paramUsername.ParameterName = "@username";
                paramUsername.Value = employee.Username;
                comm.Parameters.Add(paramUsername);

                var paramPass = comm.CreateParameter();
                paramPass.ParameterName = "@password";
                paramPass.Value = employee.Password;
                comm.Parameters.Add(paramPass);

                var paramFirstName = comm.CreateParameter();
                paramFirstName.ParameterName = "@firstName";
                paramFirstName.Value = employee.FirstName;
                comm.Parameters.Add(paramFirstName);

                IDbDataParameter paramLastName = comm.CreateParameter();
                paramLastName.ParameterName = "@lastName";
                paramLastName.Value = employee.LastName;
                comm.Parameters.Add(paramLastName);

                IDbDataParameter paramType = comm.CreateParameter();
                paramType.ParameterName = "@type";
                paramType.Value = employee.Type.ToString();
                comm.Parameters.Add(paramType);

                try
                {
                    var result = comm.ExecuteNonQuery();
                    if (result == 0)
                        throw new RepositoryException("Nothing added!");
                }
                catch (Exception e)
                {
                    throw new RepositoryException("Username already exists");
                }
            }
        }

        public void deleteAccount(String username)
        {
            IDbConnection con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Employee where username=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = username;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
                if (dataR == 0)
                    throw new RepositoryException("Nothing deleted!");
            }
        }

        public void updateAccount(Employee employee)
        {
            var con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "Update Employee Set password = @pass, firstName = @fName, lastName = @lName, type = @type where username = @username";
                var paramPass = comm.CreateParameter();
                paramPass.ParameterName = "@pass";
                paramPass.Value = employee.Password;
                comm.Parameters.Add(paramPass);

                var paramFname = comm.CreateParameter();
                paramFname.ParameterName = "@fName";
                paramFname.Value = employee.FirstName;
                comm.Parameters.Add(paramFname);

                var paramLname = comm.CreateParameter();
                paramLname.ParameterName = "@lName";
                paramLname.Value = employee.LastName;
                comm.Parameters.Add(paramLname);

                var paramType = comm.CreateParameter();
                paramType.ParameterName = "@type";
                paramType.Value = employee.Type.ToString();
                comm.Parameters.Add(paramType);

                var paramUsername = comm.CreateParameter();
                paramUsername.ParameterName = "@username";
                paramUsername.Value = employee.Username;
                comm.Parameters.Add(paramUsername);


                var result = comm.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new RepositoryException();
                }
            }
        }

        public Employee getAccount(String username, String password)
        {
            IDbConnection con = DBUtils.getConnection(props);
            Employee e = new Employee(username, password, null, null, EmployeeType.Admin);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Employee where username=@user and password=@pass";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@user";
                paramId.Value = username;
                comm.Parameters.Add(paramId);

                var paramPw = comm.CreateParameter();
                paramPw.ParameterName = "@pass";
                paramPw.Value = password;
                comm.Parameters.Add(paramPw);

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        String firstName = dataR.GetString(2);
                        String lastName = dataR.GetString(3);
                        EmployeeType type = (EmployeeType)Enum.Parse(typeof(EmployeeType), dataR.GetString(4));

                        e.FirstName = firstName;
                        e.LastName = lastName;
                        e.Type = type;
                    }
                }
            }

            if (e.FirstName == null) return null;
            else return e;
        }
    }
}
