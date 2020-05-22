using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SAPHRDB
    {
        private string connectionString = null;
        public SAPHRDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
        }
        public Student GetStudentByUID(int UID)
        {
            Student result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM SAPHR where UID = @UID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@UID", UID);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new Student;
                            result.UID = (int)dr["UID"];
                            result.Username = (string)dr["Username"];
                            result.CardID = (int)dr["CardId"];
                            
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
    }
}
