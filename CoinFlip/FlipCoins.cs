using System.Collections.Generic;

namespace CoinFlip
{
    public class FlipCoins
    {
        // This is to flip targeted times and obtain the random coin sides and add them into a list 
        public static List<Program.Sides> FlipCoin(int flipNumber)
        {
            var coinSides = new List<Program.Sides>();
            for (var i = 1; i <= flipNumber; i++)
            {
                var randomNumber = Program.Random.Next(0, 2); //https://msdn.microsoft.com/en-us/library/2dx6wyd4 to create random number
                var randomCoinSide =
                    (Program.Sides) randomNumber; //cast the randomNumber to enum type (ie. randomCoinSide)            
                coinSides.Add(randomCoinSide);
            }
            return coinSides;
        }
    }
}