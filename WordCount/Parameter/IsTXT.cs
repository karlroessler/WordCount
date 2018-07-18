using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Parameter
{
    public class IsTXT
    {
        public static string IsTXTAdress(string[] args)
        {
            string sentence = null;
            foreach (var arg in args)
            {
                if (arg.EndsWith(".txt") == true && arg.StartsWith("-dictionary") == false && arg.StartsWith("-stopwordlist") == false && arg.StartsWith("-texturl") == false)
                {
                    if (File.Exists(arg))
                    {
                        sentence = File.ReadAllText(arg);
                    }
                    else
                    {
                        Console.Write("File doesn't exist. \r\n");
                    }
                }
            }
            return sentence;
        }
    }
}
