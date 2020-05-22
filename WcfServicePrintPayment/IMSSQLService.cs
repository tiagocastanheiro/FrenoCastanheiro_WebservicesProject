using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicePrintPayment
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IMSSQLService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IMSSQLService
    {
        [OperationContract]
         double LoadWithUsername(string username, double quota);

        [OperationContract]
        double LoadWithUID(int UID, double quota);

        [OperationContract]
        double Consume(string username, int quantity);

        [OperationContract]
        double DisplayStatus(string username);

        [OperationContract]
        double DisplayStatus(int UID);
        
    }
}
