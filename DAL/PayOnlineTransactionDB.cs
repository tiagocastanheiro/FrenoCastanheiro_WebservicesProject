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
    public class PayOnlineTransactionDB : IPayOnlineTransactionDB
    {
        private string connectionString = null;
        public PayOnlineTransactionDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
        }
        public PayOnlineTransaction AddPayOnlineTransaction(PayOnlineTransaction payOnlineTransaction)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Insert into PayOnlineTransactions(Username, Amount, Date) values(@Username, @Amount, @Date);SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Username", payOnlineTransaction.Username);
                    cmd.Parameters.AddWithValue("@Date", payOnlineTransaction.Date);
                    cmd.Parameters.AddWithValue("@Amount", payOnlineTransaction.Amount);

                    cn.Open();

                    payOnlineTransaction.Id = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return payOnlineTransaction;
        }
    }
}
