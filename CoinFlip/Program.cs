using System;
using System.Collections.Generic;
using System.IO;


namespace CoinFlip
{
    public class Program
    {  
        public enum Sides
        {
            Heads,
            Tails
        }

        //This returns 1 random coin side 
        static Random random = new Random();// put it out side of method to make one instance
        static Sides Flip() // use enum type 
        {
            var randomNumber = random.Next(0, 2);             //https://msdn.microsoft.com/en-us/library/2dx6wyd4
            var randomCoinSide = (Sides)randomNumber;        //cast the randomNumber to enum type (ie. randomCoinSide)
            return randomCoinSide;
        }
        static int HeadCount(List<Sides> sides)
        {
            var headCount = 0;
            for (var i = 1; i <= sides.Count; i++)
            {
                if (Sides.Heads == sides[i - 1])
                   headCount = headCount + 1;
             }
            return headCount;
        }

        // This return 1000 random coin sides by adding them into a list
        static List<Sides> FlipCoins()
        {
            List<Sides> coinSides = new List<Sides>();
            for (var i = 1; i <= 1000; i++)
            {
                var randomCoinSide = Flip();
                coinSides.Add(randomCoinSide);
            }
            return coinSides;
        }

        static void Main(string[] args)
        {
            
            var path = @"C:\dev\coin-flip\CoinFlip\ping_flipping\coin_result.csv";

            Console.WriteLine("Flip 1 coin 1000 times with Heads or Tails:");

            //Print results          
            using (var flippingresults = new StreamWriter(path))
            {
                flippingresults.WriteLine("Flip 1 coin 1000 times with Head or Tails:");

                var coinSidesResult = FlipCoins();
                for (var i = 1; i <= 1000; i++)
                {
                    //console print detailed flipping result from list
                    Console.WriteLine($"{i} , {coinSidesResult[i - 1]}");//string interpolation
                    
                    //file print detailed flipping result from list
                    flippingresults.WriteLine($"{i} ,  {coinSidesResult[i - 1]}");                
                }

                var headsCountResult= HeadCount(coinSidesResult);
                var tailsCountResult = coinSidesResult.Count - headsCountResult;

                //console print total
                Console.WriteLine($"Total Heads:  {headsCountResult}");
                Console.WriteLine($"Total Tails:  {tailsCountResult}");

                //file print total
                flippingresults.WriteLine($"Total Heads:  {headsCountResult}");
                flippingresults.WriteLine($"Total Tails:  {tailsCountResult}");
            }

            Console.ReadKey();
        }
    }
}
