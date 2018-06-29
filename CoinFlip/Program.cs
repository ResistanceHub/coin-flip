using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var Coins = 0;
            int NoOfHeads = 0;
            int NoOfTails = 0;

            Console.WriteLine("Enter number of coins to be flipped");
            Coins = Convert.ToInt32(Console.ReadLine());
            NoOfHeads = FlippingCoinFunction(Coins);
            NoOfTails = Coins-NoOfHeads;
            WriteToFileFunction(NoOfHeads, NoOfTails);


        }

        static int FlippingCoinFunction(int Coin)
        {
            int Heads = 0;
            int Tails = 0;
            Random A = new Random();
            for (int i = 0; i < Coin; i++)
            {
                if (A.Next(0, 2) == 0)
                    Heads++;
                else

                    Tails++;
            }

            Console.WriteLine("No of Heads =" + Heads);
            Console.WriteLine("No of Tails =" + Tails);
            Console.ReadKey();
            return (Heads);
        }

        static void WriteToFileFunction(int Heads, int Tails)
        {
            using (StreamWriter writetext = new StreamWriter("MyFile.txt"))
            {
                writetext.WriteLine("Number of Heads = "+Heads +Environment.NewLine);
                writetext.WriteLine("Number of Tails = " +Tails + Environment.NewLine);
            }
        }

    }

}