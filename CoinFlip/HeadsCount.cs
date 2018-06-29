using System.Collections.Generic;
using System.Linq;

namespace CoinFlip
{
    public class HeadsCount
    { 
        //this is to count total headCounts after targeted flip times
        public static int HeadCount(List<Program.Sides> sides)
        {
            // LINQ - Language, Integrated, Query

            //var headsOnly = sides.Where((element) => element == Sides.Heads);
            //return headsOnly.Count();

            return sides.Count((elem) => elem == Program.Sides.Heads);
        }
    }
}