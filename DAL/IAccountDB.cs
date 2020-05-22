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
        Account GetAccountById(int id);

        Account GetAccountByUsername(String username);
    }

}
