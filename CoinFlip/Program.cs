using System;
using System.Collections.Generic;
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
            Console.WriteLine("Enter number of coins to be flipped");
            Coins = Convert.ToInt32(Console.ReadLine());
            FlippingCoinFunction(Coins);



        }

        static void FlippingCoinFunction(int Coin)
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

        }

    }

