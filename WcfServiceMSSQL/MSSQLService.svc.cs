using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMSSQL
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "MSSQLService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez MSSQLService.svc ou MSSQLService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class MSSQLService : IMSSQLService
    {
        public bool Consume(string username, string product, int quantity)
        {
            IAccountDB accountDB = new AccountDB();
            IAccountManager accountManager = new AccountManager(accountDB);

            return accountManager.Consume(username, product, quantity);
        }

        public Account DisplayAccountByUsername(string username)
        {
            IAccountDB accountDB = new AccountDB();
            IAccountManager accountManager = new AccountManager(accountDB);
            var account = accountManager.GetAccountByUsername(username);
            return account;
        }

        public Account DisplayAccountByUID(int UID)
        {
            IAccountDB accountDB = new AccountDB();
            IAccountManager accountManager = new AccountManager(accountDB);
            var account = accountManager.GetAccountByUID(UID);
            return account;
        }

        public bool LoadWithUID(int UID, decimal quota)
        {
            IAccountDB accountDB = new AccountDB();
            IAccountManager accountManager = new AccountManager(accountDB);
            return accountManager.TransferMoneyWithUID(UID, quota);
        }

        public bool LoadWithUsername(string username, decimal quota)
        {
            IAccountDB accountDB = new AccountDB();
            IAccountManager accountManager = new AccountManager(accountDB);
            return accountManager.TransferMoneyWithUsername(username, quota);
        }
    }
}
