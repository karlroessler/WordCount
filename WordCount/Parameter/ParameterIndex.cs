using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Parameter
{
    public class ParameterIndex
    {
        public static Boolean IsIndexTrue(string[] args)
        {
            bool ausgabe = false;
            foreach (var arg in args)
            {
                if (arg == "-index")
                {
                    ausgabe = true;
                }
            }
            return ausgabe;
        }
    }
}
