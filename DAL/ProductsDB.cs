using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductsDB : IProductsDB
    {
        private string connectionString = null;
        public ProductsDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
        }

        public decimal GetProductPrice(string product)
        {
            decimal result = -1;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Price FROM Products where Product = @Product";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Product", product);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = (decimal)dr["Price"];
                            Console.WriteLine(result);
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
