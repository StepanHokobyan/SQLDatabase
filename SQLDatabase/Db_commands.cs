using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SQLDatabase
{
    public class Db_commands
    {
        public static List<Humans> getHumans()
        {
            List<Humans> humans = new List<Humans>();
            using (SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks2;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select * from  [HumanResources].[Department] where DepartmentId > 6", connect);
                connect.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    Humans hum = new Humans();
                    hum.Id = Convert.ToInt32(read[0]);
                    hum.Name = Convert.ToString(read[1]);
                    hum.GroupName = Convert.ToString(read[2]);
                    hum.ModeDate = Convert.ToDateTime(read[3]);
                    humans.Add(hum);
                }

            }
            return humans;
        }


    }
}
