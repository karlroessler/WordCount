using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount.Functions
{
    public class SplitSentence
    {
        public static List<string> SentenceSplit(string sentence)
        {
            List<string> wordlist = new List<string>();

            System.Text.RegularExpressions.Match match = Regex.Match(sentence, @"[\w]{1,}|[\W]");
            //Sortiert alle Wörter und Sondezeichen/Zahl/Leerzeichen.

            while (match.Success)
            {
                wordlist.Add(match.Value);
                match = match.NextMatch();
            }

            return wordlist;
        }
    }
}
