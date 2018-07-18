using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Consol
{
    class ConsoleInput
    {
        public static string Input(string sentence)
        {
            ResourceManager resourceManager = new ResourceManager("WordCount.Resource.Resource", typeof(Program).Assembly);
            if (sentence == null)
            {
                Console.Write(resourceManager.GetString("ENTERTEXT"));
                sentence = Console.ReadLine();
            }

            return sentence;
        }
    }
}
