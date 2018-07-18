using Autofac;
using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCount.Implementations;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Container();


            string sentence = null;
            List<ConsoleColor> colorlist = null;

            //Args auslesen
            string language = Parameter.ParameterLang.IsLanguage(args);
            //string txtPath = Parameter.ParameterTXT.IsTXTAdress(args);
            string urlPath = Parameter.ParameterTextUrl.IsTextUrlAdress(args);
            bool index = Parameter.ParameterIndex.IsIndexTrue(args);
            bool display = Parameter.ParameterDisplay.IsDisplayTrue(args);
            bool help = Parameter.ParameterHelp.IsHelpTrue(args);
            string dictionaryPath = Parameter.ParameterDictionary.IsDictoneryPath(args);
            string stopWordPath = Parameter.ParameterStopwordlist.IsStopwordlistAdress(args);


            //Function ausführen

            if (dictionaryPath != null)
            {
                List<string> dictionarylist = Functions.ReadTXTDocument.Read(dictionaryPath);
            }

            //if (txtPath != null)
            //{
            //    List<string> txtlist = Functions.ReadTXTDocument.Read(txtPath);
            //    sentence = Functions.ConvertListToString.ListToString(txtlist);
            //}
            
            sentence = Consol.ConsoleInput.Input(sentence);
            List<string> stopwordlist = Functions.ReadTXTDocument.Read(stopWordPath);
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

        private static void Container()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder
                .RegisterType<FileSystem>()
                .As<IFileSystem>();

            containerBuilder
                .RegisterType<TextFileLoader>();

            TextFileLoader system = containerBuilder
                .Build()
                .Resolve<TextFileLoader>();

            string text = system.ReadAllText(@"C:\git\github\karlroessler\WordCount\WordCount\Test.txt");
        }
    }
}
