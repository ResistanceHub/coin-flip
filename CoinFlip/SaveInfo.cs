using System;
using System.Collections.Generic;
using System.IO;

namespace CoinFlip
{
    public class SaveInfo
    { 
        //this is to save all info on the screen or  to a file
        public static void Save(List<Program.Sides> coinSides, int headsCount, int tailsCount)
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
    }
}