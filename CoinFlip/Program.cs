using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var Coins = 0;
            Console.WriteLine("Enter number of coins to be flipped");
            Coins = Convert.ToInt32(Console.ReadLine());
            FlippingCoinFunction(Coins);
            ReadFromFile();
            ClearContentsOfFile();

        }

        static void FlippingCoinFunction(int Coin)
        {
            int Head = 0;
            int Tail = 0;
            Random A = new Random();
            List<string> iList = new List<string>();
            for(int i =0;i<Coin;i++)
            {
                if (A.Next(0, 2) == 0)
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

        static void WriteToFileFunction(List<string> iList, int Coin)
        {
            for (int i = 0; i < Coin; i++)
            {
                using (var writetext = File.AppendText("MyNewFile.csv"))
                {
                    writetext.WriteLine("{0} , {1}", i + 1, iList.ElementAt(i) + Environment.NewLine);
                }
            }
        }

        static void ReadFromFile()
        {
        //reading from the file
            using (StreamReader readtext = new StreamReader("MynewFile.csv"))
            {
                string readMeText = readtext.ReadToEnd();
                Console.WriteLine(readMeText);
                Console.ReadKey();
            }
            
        }

        static void ClearContentsOfFile()
        {
            FileStream fileStream = File.Open("MynewFile.csv" , FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Close();
        }
    }

}