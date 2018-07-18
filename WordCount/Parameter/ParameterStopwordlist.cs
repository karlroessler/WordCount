using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Parameter
{
    public class ParameterStopwordlist
    {
        public static string IsStopwordlistAdress(string[] args)
        {
            string stopWordPath = null;
            foreach (var arg in args)
            {
                if (arg.StartsWith("-stopwordlist="))
                {
                    int idx = arg.LastIndexOf('=');
                    if (File.Exists(arg.Substring(idx + 1)))
                    {
                        stopWordPath = arg.Substring(idx + 1);
                    }
                    else
                    {
                        Console.Write("Stopwordlist file doesn't exist. \r\n");
                    }

                }
            }

            if (stopWordPath == null)
            {
                ResourceManager resourceManager = new ResourceManager("WordCount.Resource.Resource", typeof(Program).Assembly);
                stopWordPath = resourceManager.GetString("STOPWORDTXTLINK");
            }

            return stopWordPath;
        }
    }
}
