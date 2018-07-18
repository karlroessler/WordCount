using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Consol
{
    public class ConsolOutput
    {
        public static void TextAusgabe(Variable variable)
        {
            List<string> textList = new List<string>();
            List<string> dataList = new List<string>();
            string ausgabe = null;
            ResourceManager resourceManager = new ResourceManager("WordCount.Resource.Resource", typeof(Program).Assembly);


            textList.Add(resourceManager.GetString("NUMBEROFWORDS"));
            dataList.Add(" " + variable.WordCount);
            textList.Add(resourceManager.GetString("UNIQUE"));
            dataList.Add(" " + variable.UniqueCount);
            textList.Add(resourceManager.GetString("AVERAGE"));
            dataList.Add(" " + variable.AverageLength + " " + resourceManager.GetString("CHARACTERS"));

            int pointLength = 0;
            int maxLength = textList.Max(str => str == null ? 0 : str.Length);

            for (int i = 0; i < textList.Count; i++)
            {
                pointLength = maxLength - textList[i].Length;
                ausgabe = ausgabe + "- " + textList[i] + new String('.', pointLength) + dataList[i] + "\r\n";
            }

            ausgabe = resourceManager.GetString("STATISTIC") + ":\r\n" + ausgabe;


            //if (variable.Index)
            //{
            //    if (variable.DictionaryPath != null)
            //    {
            //        ausgabe = ausgabe + String.Format(resourceManager.GetString("INDEXDICTONARY"), variable.UniqueCount) + ":\r\n" + result.SortedMarkedWords;
            //    }
            //    else
            //    {
            //        ausgabe = ausgabe + resourceManager.GetString("INDEX") + ":\r\n" + variable.DictionaryPath;
            //    }
            //}


            if (variable.StopWordPath != null)
            {
                ausgabe = resourceManager.GetString("STOPWORDS") + " " + variable.StopWordPath + "\r\n" + ausgabe;
            }

            Console.WriteLine(ausgabe);

            if (variable.Display)
            {
                Consol.ConsolDisplayOutput.Writer(variable.Wordlist, variable.Colorlist);
            }
        }
    }
}
