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
            string sentence = null;
            List<ConsoleColor> colorlist = null;

            //Args auslesen
            string language = Parameter.IsLang.IsLanguage(args);
            string txtPath = Parameter.IsTXT.IsTXTAdress(args);
            string urlPath = Parameter.IsTextUrl.IsTextUrlAdress(args);
            bool index = Parameter.IsIndex.IsIndexTrue(args);
            bool display = Parameter.IsDisplay.IsDisplayTrue(args);
            bool help = Parameter.IsHelp.IsHelpTrue(args);
            string dictionaryPath = Parameter.IsDictionary.IsDictoneryPath(args);
            string stopWordPath = Parameter.IsStopwordlist.IsStopwordlistAdress(args);


            //Function ausführen

            if (dictionaryPath != null)
            {
                List<string> dictionarylist = Functions.ReadTXT.Read(dictionaryPath);
            }

            if (txtPath != null)
            {
                List<string> txtlist = Functions.ReadTXT.Read(txtPath);
                sentence = Functions.ConvertListToString.ListToString(txtlist);
            }
            
            sentence = InputConsole.Input(sentence);
            List<string> stopwordlist = Functions.ReadTXT.Read(stopWordPath);
            List<string> wordlist = Functions.SplitSentence.SentenceSplit(sentence);

            if (display == true)
            {
                colorlist = Functions.SortTextColor.ColorSort(wordlist, stopwordlist);
            }

            List<string> wordlistNoSpecialCharacter = Functions.RemoveSpecialCharacter.RemoveCharacter(wordlist);
            List<string> wordlistNoStopWords = Functions.RemoveStopWords.Remove(wordlistNoSpecialCharacter, stopWordPath);


            int wordcount = Functions.CountWords.Count(wordlistNoStopWords);
            int uniquewordcount = Functions.CountUniqueWords.UniqueWord(wordlistNoStopWords);
            string wordlength = Functions.AverageWordLength.Average(wordlistNoStopWords);

            Variable variable = new Variable
            {
                Index = index,
                Display = display,
                Help = help,
                DictionaryPath = dictionaryPath,
                StopWordPath = stopWordPath,
                WordCount = wordcount,
                UniqueCount = uniquewordcount,
                AverageLength = wordlength,
                Wordlist = wordlist,
                Colorlist = colorlist
            };

            Consol.ConsolOutput.TextAusgabe(variable);
        }
    }
}
