using System;
using System.Collections.Generic;
using System.IO;


namespace CoinFlip
{
    
   
    public class Program
    {
        static Random random = new Random();// put it out side of method to make one instance
        public enum Sides
        {
            Heads,
            Tails
        }
        //This returns one coin side (1 value)
        static Sides Flip() // use enum type 
        {
            var randomNumber = random.Next(0, 2); //https://msdn.microsoft.com/en-us/library/2dx6wyd4
            var randomCoinSide = (Sides) randomNumber; //cast the randomNumber to enum type (ie. randomCoinSide)
            return randomCoinSide;
        }

        // This method return 1000 random coin sides by add them into a list
            static List<Sides> FlipCoins()
            {
              List<Sides> coinSides = new List<Sides>();
                for (var i = 1; i <= 1000; i++)
                	{
                	    var randomSide = Flip();
                		coinSides.Add(randomSide);
                	}
            		return coinSides;
            }
    
        static void Main(string[] args)
        {
            var headsCount = 0;
            var tailsCount = 0;
            var path = @"C:\dev\coin-flip\CoinFlip\ping_flipping\coin_result.csv";//
          
            Console.WriteLine("Flip 1 coin 1000 times with Heads or Tails:");

            //file print results          
            using (var flippingresults = new StreamWriter(path))
            {
                flippingresults.WriteLine("Flip 1 coin 1000 times with Head or Tails:");

                var coinSides = FlipCoins();
                for (var i = 1; i <= 1000; i++)
                {
                Console.WriteLine($"{i} , {coinSides[i-1]}");//string interpolation


                    //file print detailed flipping result from list
                    flippingresults.WriteLine($"{i} ,  {coinSides[i-1]}");

                    if (Sides.Heads == coinSides[i-1])
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
