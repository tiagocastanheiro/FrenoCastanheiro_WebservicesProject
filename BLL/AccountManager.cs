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
        public Account GetAccountById(int id)
        {
            return AccountDb.GetAccountById(id);
        }

        public Account GetAccountByUsername(string username)
        {
            return AccountDb.GetAccountByUsername(username);
        }
    }
}
