using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IProductsDB
    {
        decimal GetProductPrice(string product);
    }
}
