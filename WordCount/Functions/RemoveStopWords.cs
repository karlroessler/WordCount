using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Functions
{
    public class RemoveStopWords
    {
        public static List<string> Remove(List<string> wordlistNoSpecialCharacter, string stopWordPath)
        {
            List<string> stopWordList = File.ReadAllLines(stopWordPath).ToList();
            return wordlistNoSpecialCharacter.Except(stopWordList).ToList();
        }
    }
}
