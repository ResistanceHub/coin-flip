using System;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace CoinFlip
{
    public enum CoinSides
    {
        Heads = 0,
        Tails = 1
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var headsCount = 0;
            var tailsCount = 0;
            var path = @"C:\dev\coin-flip\CoinFlip\ping_flipping\coin_result.csv";
          
            Console.WriteLine("Flip 1 coin 1000 times with Heads (0) or Tails (1):");

            //file print results          
            using (var flippingresults = new StreamWriter(path))
            {
                flippingresults.WriteLine("Flip 1 coin 1000 times with Head (0) or Tails (1):");

                var Heads = default(CoinSides);
                for (var i = 1; i <= 1000; i++)
                {
                    var rnd = random.Next(0, 2); // https://msdn.microsoft.com/en-us/library/2dx6wyd4 - the upper bound is scluded, this will randomly produce one of these values: 0, 1                                                              
                    var coinValue = (CoinSides) rnd;

                    Console.WriteLine(i.ToString() + "," + coinValue.ToString());
                   
                    //file print detailed flipping result
                    flippingresults.WriteLine(i.ToString() + "," + coinValue.ToString());

                    if (Heads == coinValue)
                        headsCount = headsCount + 1;
                    else
                        tailsCount = tailsCount + 1;
                }

                Console.WriteLine("Total Heads" + " " + headsCount);
                Console.WriteLine("Total Tails" + " " + tailsCount);

                //file print total
                flippingresults.WriteLine("Total Heads" + " " + headsCount);
                flippingresults.WriteLine("Total Tails" + " " + tailsCount);
            }

            Console.ReadKey();
        }
    }
}
