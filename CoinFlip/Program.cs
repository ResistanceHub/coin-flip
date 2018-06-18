using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace CoinFlip
{
    public class Program
    {
        public enum Sides //default value is started from 0
        {
            Heads,
            Tails
        }
        private static readonly Random random = new Random(); // put it out side of method to make one instance
       
        // This is to flip targeted times and obtain the random coin sides and add them into a list
        public static List<Sides> FlipCoins(int flipNumber)
        {
            var coinSides = new List<Sides>();
            for (var i = 1; i <= flipNumber; i++)
            {
                var randomNumber =
                    random.Next(0, 2); //https://msdn.microsoft.com/en-us/library/2dx6wyd4 to create random number
                var randomCoinSide =
                    (Sides) randomNumber; //cast the randomNumber to enum type (ie. randomCoinSide)            
                coinSides.Add(randomCoinSide);
            }
            return coinSides;
        }
        //this is to count total headCounts after targeted flip times
        public static int HeadCount(List<Sides> sides)
        {
			// LINQ - Language, Integrated, Query
//	        var headsOnly = sides.Where((element) => element == Sides.Heads);
//	        return headsOnly.Count();

	       // return sides.Count((elem) => elem == Sides.Heads);

            var headsCount = 0;
            foreach (var coinSide in sides)
            {
                if (Sides.Heads == coinSide)
                    headsCount = headsCount + 1;
            }
            return headsCount;
        }

        //this is to save all info on the screen or  to a file
        public static void Save(List<Sides> coinSides, int headsCount, int tailsCount)
        { 
            const string path = @"C:\dev\coin-flip\CoinFlip\ping_flipping\coin_result.csv";
            using (var flipResults = new StreamWriter(path)) 
                //save to a file 
            {
                Console.WriteLine($"Flip 1 coin {coinSides.Count} times with Head or Tails:");
                flipResults.WriteLine($"Flip 1 coin {coinSides.Count} times with Head or Tails:");

                for (var i = 1; i <= coinSides.Count; i++)
                {
                    //save to console - detailed flipping result from list
                    Console.WriteLine($"{i} , {coinSides[i - 1]}"); //string interpolation

                    //save to file-detailed flipping result from list
                    flipResults.WriteLine($"{i} ,  {coinSides[i - 1]}");
                }

                //save to console - total
                Console.WriteLine($"Total Heads:  {headsCount}");
                Console.WriteLine($"Total Tails:  {tailsCount}");

                //file print total
                flipResults.WriteLine($"Total Heads:  {headsCount}");
                flipResults.WriteLine($"Total Tails:  {tailsCount}");

            }
        }

        static void Main(string[] args)
        {          
            const int flipNumber = 1000;
            var ft = flipNumber;
            var coinSidesResult = FlipCoins(flipNumber); //flip
            int headsCountResult = HeadCount(coinSidesResult); //head count
            var tailsCountResult = coinSidesResult.Count - headsCountResult; //tail count
            Save(coinSidesResult, headsCountResult, tailsCountResult);  //save info to console or file
            Console.ReadKey();
        }
    }
}
