using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace WordCount.Test
{
    public class RemoveSpecialCharacterTest
    {
        [Fact]
        public void TestMethod1()
        {
            List<string> actual = Functions.RemoveSpecialCharacter.RemoveCharacter(wordlist: new List<string> { "This", " ", "is", " ", "a", " ", "Test" });
            Assert.Equal(expected: new List<string> { "This", "is", "a", "Test" }, actual: actual);
        }
    }
}
