using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Functions
{
    public class AverageWordLength
    {
        public static string Average(List<string> wordlist)
        {
            return Math.Round(wordlist.Average(s => s.Length), 2, MidpointRounding.AwayFromZero).ToString("0.00"); ;
        }
    }
}
