using System;
using System.IO;


namespace CoinFlip
{
	class Program
	{
       static void Main(string[] args)
		{
			Random random = new Random();
		    int head = 0;
		    int tail = 0;

		    Console.WriteLine("Flip 1 coin 1000 times with Head (0) or Tails (1):"); 

          
            for (int i = 1; i <=1000; i++)
            {
				int rnd = random.Next(0, 2); // https://msdn.microsoft.com/en-us/library/2dx6wyd4 - the upper bound is scluded, this will randomly produce one of these values: 0, 1

                Console.WriteLine(i.ToString() + ' ' + rnd);               
                if (rnd ==0)
                {
                    head = head + 1;
                }

                else
                {
                    tail = tail + 1;
                }
                
            }
          
            Console.WriteLine("Total Heads" + ' ' + head);
		    Console.WriteLine("Total Tails" + ' ' + tail);

            //Add flipping results to text file
            using (StreamWriter flippingresults =
                new StreamWriter(@"C:\dev\coin-flip\CoinFlip\ping_flipping\coin_result.txt"))
            {
                flippingresults.WriteLine("Flip 1 coin 1000 times with Head (0) or Tails (1):");
                flippingresults.WriteLine("Total Heads" + " " + head);
                flippingresults.WriteLine("Total Tails" + ' ' + tail);
            }
            Console.ReadKey();
		}
	}
}
