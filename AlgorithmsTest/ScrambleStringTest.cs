using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class ScrambleStringTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(string s1, string s2, bool output)
        {
            Assert.Equal(output, Solution087.IsScramble(s1, s2));
        }
    }
}

