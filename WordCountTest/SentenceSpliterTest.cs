using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace WordCountTest
{
    public class SentenceSpliterTest
    {
        [Fact]
        public void TestMethod1()
        {
            List<string> actual = sent(sentence: "This is a Test");
            Assert.Equal(expected: new List<string> { "This", " ", "is", " ", "a", " ", "Test" }, actual: actual);
        }
    }
}
