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
			Random random = new Random(); 

			for (int i = 0; i < 5; i++)
			{
				int rnd = random.Next(0, 5); // https://msdn.microsoft.com/en-us/library/2dx6wyd4 - the upper bound is scluded, this will randomly produce one of these values: 0, 1, 2, 3, 4 - it will not produce 5
				Console.WriteLine(i.ToString() + ' ' + rnd);
			}

			Console.ReadKey();
		}
	}
}
