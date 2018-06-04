using System;
using System.Collections.Generic;
using System.IO;


namespace CoinFlip
{
    
   
    public class Program
    {
		static Random random = new Random();
		public enum Sides
        {
            Heads = 0,
            Tails = 1
        }
		// This returns one coin side (1 value)
        static Sides Flip()
        {
            int randomNumber = random.Next(0, 2); // https://msdn.microsoft.com/en-us/library/2dx6wyd4
            Sides randomCoinSide = (Sides) randomNumber;   //how to return enum type item? What is the type of 'Heads'?
	        return randomCoinSide;
        }

		// Make this function return 1000 random coin sides
	    static List<Sides> FlipCoins()
	    {
			List<Sides> coinSides = new List<Sides>();
		    for (var i = 1; i <= 1000; i++)
		    {
				Sides randomSide = Flip();
				coinSides.Add(randomSide);
		    }
		    return coinSides;
	    }

	    static void Main(string[] args)
        {
            var headsCount = 0;
            var tailsCount = 0;
            var path = @"C:\dev\coin-flip\CoinFlip\ping_flipping\coin_result.csv";
          
            Console.WriteLine("Flip 1 coin 1000 times with Heads (0) or Tails (1):");

	        var coinsSides = FlipCoins();
			Console.WriteLine(coinsSides.ToString());

            //file print results          
//            var heads = default(Sides);
            using (var flippingresults = new StreamWriter(path))
            {
                flippingresults.WriteLine("Flip 1 coin 1000 times with Head (0) or Tails (1):");

                for (var i = 1; i <= 1000; i++)
                {
					Sides coinSide = Flip();

                    Console.WriteLine($"{i} , {coinSide}");

                    //file print detailed flipping result
                    flippingresults.WriteLine($"{i} , {coinSide}");//string interpolation
                  
                    if (Sides.Heads == coinSide)
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
