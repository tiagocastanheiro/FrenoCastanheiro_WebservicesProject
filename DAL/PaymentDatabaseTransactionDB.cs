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
    public class PaymentDatabaseTransactionDB : IPaymentDatabaseTransactionDB
    {
        private string connectionString = null;
        public PaymentDatabaseTransactionDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
        }

        public PaymentDatabaseTransaction AddPaymentDatabaseTransaction(PaymentDatabaseTransaction paymentDatabaseTransaction)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Insert into PaymentDatabaseTransactions(Id, UID, Amount, Date) values(@Id, @UID, @Amount, @Date);SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Id", paymentDatabaseTransaction.Id);
                    cmd.Parameters.AddWithValue("@UID", paymentDatabaseTransaction.UID);
                    cmd.Parameters.AddWithValue("@Date", paymentDatabaseTransaction.Date);
                    cmd.Parameters.AddWithValue("@Amount", paymentDatabaseTransaction.Amount);

                    cn.Open();

                    paymentDatabaseTransaction.Id = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return paymentDatabaseTransaction;
        }
    }
}

