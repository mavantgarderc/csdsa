using System;
using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListCtorDefaultTests
{
    [Fact]
    public void Constructor_Default_InitializesWithDefaultCapacity()
    {
        ArrayList<int> list = new ArrayList<int>();

        Assert.Empty(list);
        Assert.True(list.Capacity >= 4);
    }
}
