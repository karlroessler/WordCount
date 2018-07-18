using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace WordCount.Test
{
    public class RemoveStopWordTest
    {
        [Fact]
        public void TestMethod1()
        {
            List<string> actual = Functions.RemoveStopWords.Remove(wordlistNoSpecialCharacter: new List<string> { "This", "is", "a", "Test" }, stopWordPath: "stopwords.en.txt");
            Assert.Equal(expected: new List<string> { "This", "Test" }, actual: actual);
        }
    }
}
