using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountManager : IAccountManager
    {
        private IAccountDB AccountDb { get; }

        public AccountManager(IAccountDB accountDb)
        {
            AccountDb = accountDb;
        }
        public Account GetAccountByUID(int UID)
        {
            ISAPHRDB sAPHRDB = new SAPHRDB();
            ISAPHRManager sAPHRManager = new SAPHRManager(sAPHRDB);

            string username = sAPHRManager.GetUsernameByUID(UID);

            return GetAccountByUsername(username);
        }

        public Account GetAccountByUsername(string username)
        {
            return AccountDb.GetAccountByUsername(username);
        }

        public bool TransferMoneyWithUsername(string username, decimal quota)
        {
            Account account = GetAccountByUsername(username);
            account.Amount += quota;
            var nbRowsAffected = AccountDb.UpdateAccount(account);
            if (nbRowsAffected == 0)
            {
                return false;
            }

            return true;
        }

        public bool TransferMoneyWithUID(int UID, decimal quota)
        {
            ISAPHRDB sAPHRDB = new SAPHRDB();
            ISAPHRManager sAPHRManager = new SAPHRManager(sAPHRDB);

            string username = sAPHRManager.GetUsernameByUID(UID);

            return TransferMoneyWithUsername(username, quota);

        }

        public bool Consume(string username, string product, int quantity)
        {
            IProductsDB productsDB = new ProductsDB();
            IProductsManager productsManager = new ProductsManager(productsDB);

            decimal price = productsManager.GetProductPrice(product)*quantity;            

            Account account = GetAccountByUsername(username);
            if (account.Amount - price < 0)
            {
                return false;
            }
            account.Amount -= price;

            var nbRowsAffected = AccountDb.UpdateAccount(account);
            if (nbRowsAffected == 0)
            {
                return false;
            }

            return true;
        }
    }
}
