using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace WordCount.Test
{
    public class SentenceSpliterTest
    {
        [Fact]
        public void OnlyWords()
        {
            List<string> actual = Functions.SplitSentence.SentenceSplit(sentence: "This is a Test");
            Assert.Equal(expected: new List<string> { "This", " ", "is", " ", "a", " ", "Test" }, actual: actual);
        }

        [Fact]
        public void OnlyExtra()
        {
            List<string> actual = Functions.SplitSentence.SentenceSplit(sentence: ". / :: ''");
            Assert.Equal(expected: new List<string> { ".", " ", "/", " ", ":", ":", " ", "'", "'" }, actual: actual);
        }

        [Fact]
        public void CompleteSentece()
        {
            List<string> actual = Functions.SplitSentence.SentenceSplit(sentence: "This is a test sentence.");
            Assert.Equal(expected: new List<string> { "This", " ", "is", " ", "a", " ", "test", " ", "sentence", "."}, actual: actual);
        }
    }
}
