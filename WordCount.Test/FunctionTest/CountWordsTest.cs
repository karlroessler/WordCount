using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace WordCount.Test
{
    public class CountWordsTest
    {
        [Fact]
        public void TestMethod1()
        {
            int actual = Functions.CountWords.Count(wordlist: new List<string> { "This", "is", "a", "Test" });
            Assert.Equal(expected: 4 , actual: actual);
        }
    }
}
