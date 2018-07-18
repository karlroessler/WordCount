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
        public static List<string> Read(string path)
        {
            return File.ReadAllLines(path).ToList();
        }
    }
}
