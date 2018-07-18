using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Functions
{
    public class ReadTXTDocument
    {
        public static string[] ReadText(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
