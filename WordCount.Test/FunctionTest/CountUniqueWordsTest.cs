using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WordCount.Test
{
    class CountUniqueWordsTest
    {
        [Fact]
        public void AllAreUnque()
        {
            int actual = Functions.CountUniqueWords.UniqueWord(wordlist: new List<string> { "This", "is", "a", "Test" });
            Assert.Equal(expected: 4, actual: actual);
        }

        [Fact]
        public void AllAreTheSame()
        {
            int actual = Functions.CountUniqueWords.UniqueWord(wordlist: new List<string> { "Test", "Test", "Test", "Test" });
            Assert.Equal(expected: 1, actual: actual);
        }
    }
}
