using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PaymentDatabaseTransactionManager : IPaymentDatabaseTransactionManager
    {
        private IPaymentDatabaseTransactionDB PaymentDatabaseTransactionDb { get; }
        public PaymentDatabaseTransactionManager(IPaymentDatabaseTransactionDB paymentDatabaseTransactionDb)
        {
            PaymentDatabaseTransactionDb = paymentDatabaseTransactionDb;
        }
        public PaymentDatabaseTransaction AddPaymentDatabaseTransaction(PaymentDatabaseTransaction paymentDatabaseTransaction)
        {
            return PaymentDatabaseTransactionDb.AddPaymentDatabaseTransaction(paymentDatabaseTransaction);
        }

    }
}
