using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicePrintPayment
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "MSSQLService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez MSSQLService.svc ou MSSQLService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    //
    public class MSSQLService : IMSSQLService1
    {
        public bool Consume(string username, string product, int quantity)
        {
            IAccountDB accountDB = new AccountDB();
            IAccountManager accountManager = new AccountManager(accountDB);

            return accountManager.Consume(username, product, quantity);
        }

        public decimal DisplayAmountByUsername(string username)
        {
            IAccountDB accountDB = new AccountDB();
            IAccountManager accountManager = new AccountManager(accountDB);
            var account = accountManager.GetAccountByUsername(username);
            return account.Amount;
        }

        public decimal DisplayAmountByUID(int UID)
        {
            IAccountDB accountDB = new AccountDB();
            IAccountManager accountManager = new AccountManager(accountDB);
            var account = accountManager.GetAccountByUID(UID);
            return account.Amount; 
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
