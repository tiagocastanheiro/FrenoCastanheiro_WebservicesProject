using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IAccountManager
    {
        Account GetAccountByUID(int UID);

        Account GetAccountByUsername(string username);

        bool TransferMoneyWithUsername(string username, decimal quota);

        bool TransferMoneyWithUID(int UID, decimal quota);

        bool Consume(string username, string product, int quantity);
    }
}
