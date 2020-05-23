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
            var result = mSSQLServiceClient.DisplayAmountByUsername("gabriell.freno");
            Console.WriteLine($"gabriell.freno : CHF {result}");
            
            var result1 = mSSQLServiceClient.DisplayAmountByUID(22222);
            Console.WriteLine($"UID 22222 : CHF {result1}");

            //Transfert
            Console.WriteLine($"------------------------------------------------");
            if (!mSSQLServiceClient.LoadWithUsername("gabriell.freno", 100))
            {
                Console.WriteLine($"Error : Transfer not done");
            }
            result = mSSQLServiceClient.DisplayAmountByUsername("gabriell.freno");
            Console.WriteLine($"gabriell.freno : CHF {result}");

            if (!mSSQLServiceClient.LoadWithUID(22222, 100))
            {
                Console.WriteLine($"Error : Transfer not done");
            }
            result1 = mSSQLServiceClient.DisplayAmountByUID(22222);
            Console.WriteLine($"UID 22222 : CHF {result1}");

            //Consomme
            Console.WriteLine($"------------------------------------------------");
            if (!mSSQLServiceClient.Consume("gabriell.freno", "1A4c", 40))
            {
                Console.WriteLine($"Error : Transfer not done");
            }
            result = mSSQLServiceClient.DisplayAmountByUsername("gabriell.freno");
            Console.WriteLine($"gabriell.freno : CHF {result}");

            if (!mSSQLServiceClient.Consume("tiago.garciaca", "1A4bw", 40))
            {
                Console.WriteLine($"Error : Transfer not done");
            }
            result1 = mSSQLServiceClient.DisplayAmountByUID(22222);
            Console.WriteLine($"UID 22222 : CHF {result1}");



        }
    }
}
