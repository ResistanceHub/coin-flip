using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CoinFlip;


namespace FlippingCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var Coins = 0;
            Console.WriteLine("Enter number of coins to be flipped");
            Coins = Convert.ToInt32(Console.ReadLine());
            var flipCoins = new FlipTheCoins();
            var readFile = new ReadFrmFile();
            flipCoins.FlippingCoin(Coins);
            readFile.ReadFromFile();
        }
    }

 }