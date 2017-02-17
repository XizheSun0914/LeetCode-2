using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveDuplicatesfromSortedListTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(ListNode head, ListNode output)
        {
            Assert.Equal(output, Solution083.DeleteDuplicates(head));
        }
    }
}

