using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlippingCoins;

namespace CoinFlip
{
    class FlipTheCoins
    {
        public static void FlippingCoin(int Coin) //Flipping the Coins and storing results in list
        {
            int Head = 0;
            int Tail = 0;
            Random A = new Random();
            var iList = new List<string>();

            for (int i = 0; i < Coin; i++)
            {
                if (A.Next(0, 2) == 0)
                {
                    iList.Add(Enum.GetName(typeof(Result), 0));
                    Head++;
                }
                else
                {
                    iList.Add(Enum.GetName(typeof(Result), 1));
                    Tail++;
                }

            }
            Console.WriteLine("Number of heads =" + Head);
            Console.WriteLine("Number of tails =" + Tail);
            WriteInFile.WriteToFile(iList);

        }
    }
}
