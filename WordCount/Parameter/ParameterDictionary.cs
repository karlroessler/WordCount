using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Parameter
{
    public class IsDictionary
    {
        public static string IsDictoneryPath(string[] args)
        {
            ResourceManager resourceManager = new ResourceManager("WordCount.Resource.Resource", typeof(Program).Assembly);
            string dictoneryAdress = null;
            foreach (var arg in args)
            {
                if (arg.StartsWith("-dictionary"))
                {
                    int idx = arg.LastIndexOf('=');
                    if (File.Exists(arg.Substring(idx + 1)))
                    {
                        dictoneryAdress = arg.Substring(idx + 1);
                    }
                    else
                    {
                        Console.Write(resourceManager.GetString("DICTONARYNOTEXIST"));
                    }

                }
            }
            return dictoneryAdress;
        }
    }
}
