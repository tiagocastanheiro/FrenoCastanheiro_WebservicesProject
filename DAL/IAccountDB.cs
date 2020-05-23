using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IAccountDB
    {
        Account GetAccountByUID(int UID);

        Account GetAccountByUsername(string username);

        int UpdateAccount(Account account);

    }

}
