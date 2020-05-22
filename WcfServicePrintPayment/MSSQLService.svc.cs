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
    public class MSSQLService : IMSSQLService
    {
        public double Consume(string username, int quantity)
        {
            /*IPersonDB personDb = new PersonDB();
            IPersonManager personManager = new PersonManager(personDb);
            var person = personManager.GetPersonById(id);
            return person.FirstName;*/
            return 0;
        }

        public double DisplayStatus(string username)
        {
            IAccountDB accountDB = new AccountDB();
            IAccountManager accountManager = new AccountManager(accountDB);
            var account = accountManager.GetAccountByUsername(username);
            return account.Amount;
        }

        public double DisplayStatus(int UID)
        {
            ISAPHRDB sAPHRDB = new SAPHRDB();

            IAccountDB accountDB = new AccountDB();
            IAccountManager accountManager = new AccountManager(accountDB);
            var account = accountManager.GetAccountByUID(UID);
            return account.Amount;
        }

        public double LoadWithUID(int UID, double quota)
        {
            throw new NotImplementedException();
        }

        public double LoadWithUsername(string username, double quota)
        {
            throw new NotImplementedException();
        }
    }
}
