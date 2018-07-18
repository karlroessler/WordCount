using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCount.Interfaces;

namespace WordCount.Implementations
{
    public class TextFileLoader : ITextFileLoader
    {
        private readonly IFileSystem _fileSystem;

        public TextFileLoader(
            IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public string ReadAllText(string path)
        {
            return _fileSystem.File.ReadAllText(path: path);
        }
    }
}
