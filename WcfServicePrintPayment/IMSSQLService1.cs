﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicePrintPayment
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IMSSQLService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IMSSQLService1
    {
        [OperationContract]
        bool LoadWithUsername(string username, decimal quota);

        [OperationContract]
        bool LoadWithUID(int UID, decimal quota);

        [OperationContract]
        bool Consume(string username, string product, int quantity);

        [OperationContract]
        decimal DisplayAmountByUsername(string username);

        [OperationContract]
        decimal DisplayAmountByUID(int UID);
        
    }
}