using System;
using System.Collections.Generic;
using Csdsa.DataStructures.Lists;
using Xunit;

namespace Csdsa.Tests.DataStructures.Lists;

public class ListTNullInputTests
{
    [Fact]
    public void Operations_NullInput_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => ListT.Add<int>(null, 1));
        Assert.Throws<ArgumentException>(() => ListT.InsertAt<int>(null, 0, 1));
        Assert.Throws<ArgumentException>(() => ListT.RemoveAt<int>(null, 0));
        Assert.Throws<ArgumentException>(() => ListT.SortAscending<int>(null));
        Assert.Throws<ArgumentException>(() => ListT.SortDescending<int>(null));
        Assert.Throws<ArgumentException>(() => ListT.Reverse<int>(null));
        Assert.Throws<ArgumentException>(() => ListT.Clone<int>(null));
        Assert.Throws<ArgumentException>(() => ListT.Merge<int>(null, new List<int>()));
        Assert.Throws<ArgumentException>(() => ListT.Merge<int>(new List<int>(), null));
    }
}
