using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace WordCount.Test.FunctionTest
{
    public class ReadTXTDocumentTest
    {
        [Fact]
        public void TestMethod1()
        {
            string[] actual = Functions.ReadTXTDocument.ReadText(path: "test.txt" );
            Assert.Equal(expected: new string[] {"a","about","above","after" }, actual: actual);
        }
    }
}
