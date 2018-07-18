using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Functions
{
    public class CountUniqueWords
    {
        public static int UniqueWord(List<string> wordlist)
        {
            return wordlist.Distinct().Count();
        }
    }
}
