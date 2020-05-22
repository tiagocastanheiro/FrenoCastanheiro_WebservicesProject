using DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace DAL
{
    public class PaymentDatabaseTransactionDB : IPaymentDatabaseTransactionDB
    {
        private string connectionString = null;
    public PaymentDatabaseTransactionDB(IConfiguration configuration)
    {
        var config = configuration;
        connectionString = config.GetConnectionString("DefaultConnection");
    }
    
        public PaymentDatabaseTransaction AddTransaction(PaymentDatabaseTransaction pdt)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO PaymentDatabaseTransactions(Id, UID, Amount, Date) VALUES(@Id, @UID, @Amount, @Date); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Id", pdt.Id);
                    cmd.Parameters.AddWithValue("@UID", pdt.UID);
                    cmd.Parameters.AddWithValue("@Amount", pdt.Amount);
                    cmd.Parameters.AddWithValue("@Date", pdt.Date);

                    cn.Open();

                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return pdt;
        }
    }
    
}
