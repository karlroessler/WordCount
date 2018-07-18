using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Consol
{
    class ConsolDisplayOutput
    {
        public static void Writer(List<string> wordlist, List<ConsoleColor> colorlist)
        {
            for (int i = 0; i < wordlist.Count; i++)
            {
                Console.ResetColor();
                Console.ForegroundColor = colorlist[i];
                Console.Write(wordlist[i]);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
