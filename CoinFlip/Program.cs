using System;

namespace CoinFlip
{
    public class Program
    {
        public enum Sides //default value is started from 0
        {
            Heads,
            Tails
        }

       public static readonly Random Random = new Random();        
        static void Main(string[] args)
        {          
            const int flipNumber = 1000;
            var coinSidesResult = FlipCoins.FlipCoin(flipNumber); //flip
            int headsCountResult = HeadsCount.HeadCount(coinSidesResult); //head count
            var tailsCountResult = coinSidesResult.Count - headsCountResult; //tail count
            SaveInfo.Save(coinSidesResult, headsCountResult, tailsCountResult);  //save info to console or file
            Console.ReadKey();
        }
    }
}
