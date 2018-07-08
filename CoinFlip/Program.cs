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
            WriteToFileFunction(iList);
             
        }

        static void WriteToFileFunction(List<string> iList)                                                               //Writing results in the file
        {
            using (var writetext = new StreamWriter("MyNewFile.csv"))
            {
                foreach (var variable in iList)
                {
                    writetext.WriteLine("{0} ", variable  + Environment.NewLine);
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
    }

}