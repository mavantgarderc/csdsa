using System;
using System.Collections.Generic;
using Csdsa.DataStructures.Lists;
using Xunit;

namespace Csdsa.Tests.DataStructures.Lists;

public class ListTInsertAtTests
{
    [Fact]
    public void InsertAt_InsertAtCorrectPosition()
    {
        List<char> list = new List<char> { 'a', 'b', 'd' };

        ListT.InsertAt(list, 2, 'c');

        Assert.Equal('c', list[2]);
        Assert.Equal(4, list.Count);
    }

    [Fact]
    public void InsertAt_InvalidIndex_ThrowsException()
    {
        List<int> list = new List<int> { 1, 2, 3 };

        Assert.Throws<ArgumentException>(() => ListT.InsertAt(list, -1, 4));
        Assert.Throws<ArgumentException>(() => ListT.InsertAt(list, 4, 4));
    }
}
