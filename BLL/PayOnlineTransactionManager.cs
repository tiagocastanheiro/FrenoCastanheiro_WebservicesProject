using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class PayOnlineTransactionManager : IPayOnlineTransactionManager
    {
        private PayOnlineTransactionDB PayOnlineTransactionDB { get; }

        public PayOnlineTransactionManager(PayOnlineTransactionDB payOnlineTransactionDB)
        {
            PayOnlineTransactionDB = payOnlineTransactionDB;
        }
        public PayOnlineTransaction AddPayOnlineTransaction(PayOnlineTransaction payOnlineTransaction)
        {
            return PayOnlineTransactionDB.AddPayOnlineTransaction(payOnlineTransaction);
        }
    }
}
