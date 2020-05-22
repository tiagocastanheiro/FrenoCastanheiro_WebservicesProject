using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PaymentDatabaseTransaction
    {
        public int Id { get; set; }
        public int UID { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
