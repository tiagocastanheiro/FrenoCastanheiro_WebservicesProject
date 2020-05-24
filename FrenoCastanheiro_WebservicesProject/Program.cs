using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenoCastanheiro_WebservicesProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            ServiceReferenceMSSQL.MSSQLServiceClient mSSQLServiceClient = new ServiceReferenceMSSQL.MSSQLServiceClient();
            
            //Affiche
            var result = mSSQLServiceClient.DisplayAccountByUsername("gabriell.freno");
            Console.WriteLine($"{result.Username} : CHF {result.Amount}");
            
            var result1 = mSSQLServiceClient.DisplayAccountByUID(22222);
            Console.WriteLine($"UID 22222 : CHF {result1.Amount}");

            //Transfert
            Console.WriteLine($"------------------------------------------------");
            if (!mSSQLServiceClient.LoadWithUsername("gabriell.freno", 100))
            {
                Console.WriteLine($"Error : Transfer not done");
            }
            result = mSSQLServiceClient.DisplayAccountByUsername("gabriell.freno");
            Console.WriteLine($"{result.Username} : CHF {result.Amount}");

            if (!mSSQLServiceClient.LoadWithUID(22222, 100))
            {
                Console.WriteLine($"Error : Transfer not done");
            }
            result1 = mSSQLServiceClient.DisplayAccountByUID(22222);
            Console.WriteLine($"UID 22222 : CHF {result1.Amount}");

            //Consomme
            Console.WriteLine($"------------------------------------------------");
            if (!mSSQLServiceClient.Consume("gabriell.freno", "1A4c", 40))
            {
                Console.WriteLine($"Error : Transfer not done");
            }
            result = mSSQLServiceClient.DisplayAccountByUsername("gabriell.freno");
            Console.WriteLine($"{result.Username} : CHF {result.Amount}");

            if (!mSSQLServiceClient.Consume("tiago.garciaca", "1A4bw", 40))
            {
                Console.WriteLine($"Error : Transfer not done");
            }
            result1 = mSSQLServiceClient.DisplayAccountByUID(22222);
            Console.WriteLine($"UID 22222 : CHF {result1.Amount}");



        }
    }
}
