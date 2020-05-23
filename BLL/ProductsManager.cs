using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductsManager : IProductsManager
    {
        private IProductsDB ProductsDb { get; }

        public ProductsManager(IProductsDB productsDb)
        {
            ProductsDb = productsDb;
        }

        public decimal GetProductPrice(string product)
        {
            return ProductsDb.GetProductPrice(product);
        }
    }
}
