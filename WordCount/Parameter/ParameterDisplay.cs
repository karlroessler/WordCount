using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Parameter
{
    public class ParameterDisplay
    {
        public static Boolean IsDisplayTrue(string[] args)
        {
            bool ausgabe = false;
            foreach (var arg in args)
            {
                if (arg == "-display")
                {
                    ausgabe = true;
                }
            }
            return ausgabe;
        }
    }
}
