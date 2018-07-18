using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Functions
{
    public class RemoveStopWords
    {
        public static List<string> Remove(List<string> wordlistNoSpecialCharacter, string stopWordPath)
        {
            List<string> stopWordList = ReadTXTDocument.ReadText(stopWordPath).ToList();
            return wordlistNoSpecialCharacter.Except(stopWordList).ToList();
        }
    }
}
