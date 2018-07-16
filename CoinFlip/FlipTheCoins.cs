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
            Random RandNo = new Random();
            var iList = new List<string>();

            for (int i = 0; i < Coin; i++)
            {
                if (RandNo.Next(0, 2) == 0)
                {
                    iList.Add(Result.Heads.ToString());
                    Head++;
                }
                else
                {
                    iList.Add(Result.Tails.ToString());
                    Tail++;
                }

            }
            Console.WriteLine("Number of heads =" + Head);
            Console.WriteLine("Number of tails =" + Tail);
            WriteInFile.WriteToFile(iList);

        }
    }
}
