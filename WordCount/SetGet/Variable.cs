using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class Variable
    {
        public Boolean Index { get; set; }
        public Boolean Display { get; set; }
        public Boolean Help { get; set; }
        public string DictionaryPath { get; set; }
        public string StopWordPath { get; set; }
        public int WordCount { get; set; }
        public int UniqueCount { get; set; }
        public string AverageLength { get; set; }
        public List<string> Wordlist { get; set; }
        public List<string> WordlistNoStopWords { get; set; }
        public List<ConsoleColor> Colorlist { get; set; }
    }
}
