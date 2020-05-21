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
        Account GetAccountById(int id);

        Account GetAccountByUsername(String username);
    }
}
