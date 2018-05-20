using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var heads = 0;
            var tails = 0;
            var path = @"C:\dev\coin-flip\CoinFlip\ping_flipping\coin_result.csv";
          

            //console print title
            Console.WriteLine("Flip 1 coin 1000 times with Head (0) or Tails (1):");

            //file print result
            using (var flippingresults = new StreamWriter(path))
            {
                flippingresults.WriteLine("Flip 1 coin 1000 times with Head (0) or Tails (1):");
                for (var i = 1; i <= 1000; i++)
                {
                    var rnd = random.Next(0, 2); // https://msdn.microsoft.com/en-us/library/2dx6wyd4 - the upper bound is scluded, this will randomly produce one of these values: 0, 1                  
                    var message = rnd == 0 ? "Heads" : "Tails";
                    //console print detailed flipping result
                    Console.WriteLine(i.ToString() + "," + message);
                    //file print detailed flipping result
                    flippingresults.WriteLine(i.ToString() + "," + message);

                    if (rnd == 0)
                        heads = heads + 1;
                    else
                        tails = tails + 1;
                }

                //console print total
                Console.WriteLine("Total Heads" + " " + heads);
                Console.WriteLine("Total Tails" + " " + tails);

                //file print total
                flippingresults.WriteLine("Total Heads" + " " + heads);
                flippingresults.WriteLine("Total Tails" + " " + tails);
            }

            Console.ReadKey();
        }
    }
}
