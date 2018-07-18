using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount.Functions
{
    public class RemoveSpecialCharacter
    {
        public static List<string> RemoveCharacter(List<string> wordlist)
        {
            List<string> cleanwordlist = new List<string>();
       
            foreach (string word in wordlist)
            {
                Match test = Regex.Match(word, @"[\w]");
                if (test.Success)
                {
                    cleanwordlist.Add(word);
                }
            }

            return cleanwordlist;
        }

    }
}
