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
    public class FacultyTransactionDB : IFacultyTransactionDB
    {
        private string connectionString = null;
        public FacultyTransactionDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
        }
        public FacultyTransaction AddTransaction(FacultyTransaction facultiesTransaction)
        { 
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Insert into FacultiesTransactions(Username, Amount, Date) values(@Username, @Amount, @Date);SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Username", facultiesTransaction.Username);
                    cmd.Parameters.AddWithValue("@Date", facultiesTransaction.Date);
                    cmd.Parameters.AddWithValue("@Amount", facultiesTransaction.Amount);

                    cn.Open();

                    facultiesTransaction.Id = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return facultiesTransaction;
        }
    }
}
