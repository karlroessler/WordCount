using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //start Variable
            string sentence = null;

            //Args auslesen
            string language = Parameter.IsLang.IsLanguage(args);
            

            bool index = Parameter.IsIndex.IsIndexTrue(args);
            bool display = Parameter.IsDisplay.IsDisplayTrue(args);
            string dictionaryPath = Parameter.IsDictionary.IsDictoneryPath(args);
            string stopWordPath = Parameter.IsStopwordlist.IsStopwordlistAdress(args);


            //Function ausführen
            sentence = InputConsole.Input(sentence);
            List<string> wordlist = Functions.SplitSentence.SentenceSplit(sentence);
            List<string> wordlistNoSpecialCharacter = Functions.RemoveSpecialCharacter.RemoveCharacter(wordlist);
            List<string> wordlistNoStopWords = Functions.RemoveStopWords.Remove(wordlistNoSpecialCharacter, stopWordPath);

            int wordcount = Functions.CountWords.Count(wordlistNoStopWords);
            int uniquewordcount = Functions.CountUniqueWords.UniqueWord(wordlistNoStopWords);
            string wordlength = Functions.AverageWordLength.Average(wordlistNoStopWords);
        }
    }
}
