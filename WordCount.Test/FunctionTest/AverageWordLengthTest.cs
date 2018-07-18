using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WordCount.Test
{
    public class AverageWordLengthTest
    {
        [Fact]
        public void TestMethod1()
        {
            string actual = Functions.AverageWordLength.Average(wordlist: new List<string> { "This", "is", "a", "Test" });
            Assert.Equal(expected: "2,75", actual: actual);
        }
    }
}
