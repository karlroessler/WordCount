using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount.Functions
{
    class SortTextColor
    {
        public static List<ConsoleColor> ColorSort(List<string> wordlist, List<string> stopWordList)
        {
            List<ConsoleColor> colorlist = new List<ConsoleColor>();
            foreach (var testword in wordlist)
            {
                Match test = Regex.Match(testword, "[a-zA-Z]");
                if (test.Success)
                {
                    if (stopWordList.Contains(testword) == false)
                    {
                        colorlist.Add(ConsoleColor.White);
                    }
                    else
                    {
                        colorlist.Add(ConsoleColor.Red);
                    }
                }
                else
                {
                    colorlist.Add(ConsoleColor.Yellow);
                }
            }

            return colorlist;
        }
    }
}
