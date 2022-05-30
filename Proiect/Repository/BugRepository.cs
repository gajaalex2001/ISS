using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectISS.Model;
using System.Data;


namespace ProiectISS.Repository
{
    public class BugRepository
    {
        IDictionary<String, string> props;

        public BugRepository(IDictionary<string, string> props)
        {
            this.props = props;
        }

        public List<Bug> getBugs()
        {
            IDbConnection con = DBUtils.getConnection(props);
            List<Bug> bugs = new List<Bug>();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT * from Bug";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int id = dataR.GetInt32(0);
                        String description = dataR.GetString(1);
                        Severity severity = (Severity)Enum.Parse(typeof(Severity), dataR.GetString(2));
                        Priority priority = (Priority)Enum.Parse(typeof(Priority), dataR.GetString(3));

                        Bug b = new Bug(id, description, severity, priority);
                        bugs.Add(b);
                    }
                }
            }

            return bugs;
        }

        public void addBug(Bug bug)
        {
            IDbConnection con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "insert into Bug(description, severity, priority) values (@description, @severity, @priority)";
                var paramDesc = comm.CreateParameter();
                paramDesc.ParameterName = "@description";
                paramDesc.Value = bug.Description;
                comm.Parameters.Add(paramDesc);

                var paramSeve = comm.CreateParameter();
                paramSeve.ParameterName = "@severity";
                paramSeve.Value = bug.Severity;
                comm.Parameters.Add(paramSeve);

                var paramPrio = comm.CreateParameter();
                paramPrio.ParameterName = "@priority";
                paramPrio.Value = bug.Priority;
                comm.Parameters.Add(paramPrio);

                try
                {
                    var result = comm.ExecuteNonQuery();
                    if (result == 0)
                        throw new RepositoryException("Nothing added!");
                }
                catch (Exception)
                {
                    throw new RepositoryException("Something went wrong :(");
                }
            }
        }

        public void fixBug(int id)
        {
            IDbConnection con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Bug where id=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
                if (dataR == 0)
                    throw new RepositoryException("Nothing deleted!");
            }
        }
    }
}
