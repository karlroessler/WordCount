using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Parameter
{
    public class ParameterHelp
    {
        public static Boolean IsHelpTrue(string[] args)
        {
            bool ausgabe = false;
            foreach (var arg in args)
            {
                if (arg == "-help" || arg == "-h")
                {
                    ausgabe = true;
                }
            }
            return ausgabe;
        }
    }
}
