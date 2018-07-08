using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class WriteInFile
    {
        public static void WriteToFile(List<string> iList) //Writing results in the file
        {
            int i = 0;
            using (var writetext = new StreamWriter("MyNewFile.csv"))
            {
                foreach (var variable in iList)
                {
                    i++;
                    writetext.WriteLine("{0} , {1} ", i , variable + Environment.NewLine);
                }
            }
        }

    }
}
