using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Functions
{
    public class ConvertListToString
    {
        public static string ListToString(List<string> list)
        {
            return string.Join(Environment.NewLine, list.ToArray());
        }
    }
}
