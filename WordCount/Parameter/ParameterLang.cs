using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Parameter
{
    public class ParameterLang
    {
        public static string IsLanguage(string[] args)
        {
            string language = null;
            string ausgabe = null;
            foreach (var arg in args)
            {
                if (arg.StartsWith("-lang"))
                {
                    int idx = arg.LastIndexOf('=');
                    language = arg.Substring(idx + 1);

                    if (language == "de" || language == "en")
                    {
                        ausgabe = language;
                    }
                    else
                    {
                        Console.Write($"Laguage \"{language}\" not supported. \r\n");
                        ausgabe = "en";
                    }
                }
            }
            return ausgabe;
        }
    }
}
