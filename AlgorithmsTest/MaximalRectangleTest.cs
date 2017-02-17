using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class MaximalRectangleTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(char[,] matrix, int output)
        {
            Assert.Equal(output, Solution085.MaximalRectangle(matrix));
        }
    }
}

