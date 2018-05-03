using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("======Flipping a coin 1000 times======");
			CoinFlip();
		}


		private static void CoinFlip()
		{
            Random random = new Random(); 
			int noOfHeads = 0;
			int noOfTails = 0;

			for (int i = 0; i < 1000; i++)
			{
				int rnd = random.Next(0, 2); // https://msdn.microsoft.com/en-us/library/2dx6wyd4 - the upper bound is scluded, this will randomly produce one of these values: 0, 1, 2, 3, 4 - it will not produce 5
				
				if(rnd == 1)
				{
					noOfHeads++;
				}
				else
				{
					noOfTails++;
				}				
			}
			Console.WriteLine("Heads were flipped {0} times", noOfHeads);
            Console.WriteLine("Tails were flipped {0} times", noOfTails);
			Console.ReadKey();
		}
	}
}
