using System;
using System.IO;


namespace CoinFlip
{
    
   
    public class Program
    {
        public enum CoinFlip
        {
            Heads = 0,
            Tails = 1
        }
        static int FlipValue()
        {
            var random = new Random();
            var rnd = random.Next(0, 2); https://msdn.microsoft.com/en-us/library/2dx6wyd4
            return rnd;   //how to return enum type item? What is the type of 'Heads'?
        }
        static void Main(string[] args)
        {
            var headsCount = 0;
            var tailsCount = 0;
            var path = @"C:\dev\coin-flip\CoinFlip\ping_flipping\coin_result.csv";
          
            Console.WriteLine("Flip 1 coin 1000 times with Heads (0) or Tails (1):");

            //file print results          
            var heads = default(CoinFlip);
            using (var flippingresults = new StreamWriter(path))
            {
                flippingresults.WriteLine("Flip 1 coin 1000 times with Head (0) or Tails (1):");

                for (var i = 1; i <= 1000; i++)
                {
                  var coinSide = (CoinFlip) FlipValue();

                    Console.WriteLine($"{i} , {coinSide}");

                    //file print detailed flipping result
                    flippingresults.WriteLine($"{i} , {coinSide}");//string interpolation
                  
                    if (heads == coinSide)
                        headsCount = headsCount + 1;
                    else
                        tailsCount = tailsCount + 1;
                }

                Console.WriteLine($"Total Heads:  {headsCount}");
                Console.WriteLine($"Total Tails:  {tailsCount}");

                //file print total
                flippingresults.WriteLine($"Total Heads:  {headsCount}");
                flippingresults.WriteLine($"Total Tails:  {tailsCount}");
            }

            Console.ReadKey();
        }
    }
}
