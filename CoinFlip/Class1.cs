using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class ReadFrmFile
    {
        public static void ReadFromFile()                                                                                                  //Reading from file on Console
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
