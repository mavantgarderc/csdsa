using System;
using System.Collections.Generic;
using Csdsa.DataStructures.Lists;
using Xunit;

namespace Csdsa.Tests.DataStructures.Lists;

public class ListTRemoveAtTests
{
    [Fact]
    public void RemoveAt_RemoveCorrectElement()
    {
        List<int> list = new List<int> { 1, 2, 3 };

        ListT.RemoveAt(list, 1);

        Assert.Equal(new[] { 1, 3 }, list);
    }

    [Fact]
    public void RemoveAt_InvalidIndex_ThrowsException()
    {
        List<int> list = new List<int> { 1, 2 };

        Assert.Throws<ArgumentException>(() => ListT.RemoveAt(list, 2));
    }
}
