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
    }
}
