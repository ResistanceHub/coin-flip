using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingCoins
{
    enum Result
    {
        Heads,
        Tails
    };
    
        
    
    class Program
    {
        static void Main(string[] args)
        {
            var Coins = 0;
            Console.WriteLine("Enter number of coins to be flipped");
            Coins = Convert.ToInt32(Console.ReadLine());
            ClearContentsOfFile();
            FlippingCoinFunction(Coins);
            ReadFromFile();
            

        }

        static void FlippingCoinFunction(int Coin)                                                                              //Flipping the Coins and storing results in list
        {
            int Head = 0;
            int Tail = 0;
            int Next;
            Random A = new Random();
            List<string> iList = new List<string>();
            for(int i =0;i<Coin;i++)
            {
                
                 if(A.Next(0, 2)==(int)Result.Heads)
                {
                    iList.Add("Heads");
                    Head++;
                }
                else
                {
                    iList.Add("Tails");
                    Tail++;
                }
                    
            }
            Console.WriteLine("Number of heads =" + Head);
            Console.WriteLine("Number of tails =" + Tail);
            WriteToFileFunction(iList , Coin);
             
        }

        static void WriteToFileFunction(List<string> iList, int Coin)                                                               //Writing results in the file
        {
            for (int i = 0; i < Coin; i++)
            {
                using (var writetext = File.AppendText("MyNewFile.csv"))
                {
                    writetext.WriteLine("{0} , {1}", i + 1, iList.ElementAt(i) + Environment.NewLine);
                }
            }
        }

        static void ReadFromFile()                                                                                                  //Reading from file on Console
        {
            using (StreamReader readtext = new StreamReader("MynewFile.csv"))
            {
                string readMeText = readtext.ReadToEnd();
                Console.WriteLine(readMeText);
                Console.ReadKey();
            }
            
        }

        static void ClearContentsOfFile()                                                                                           //Clearing the contents of file
        {
            FileStream fileStream = File.Open("MynewFile.csv" , FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Close();
        }
    }

}