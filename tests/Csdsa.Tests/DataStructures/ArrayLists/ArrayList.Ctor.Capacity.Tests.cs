using System;
using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListCtorCapacityTests
{
    [Fact]
    public void Constructor_WithCapacity_InitializesCorrectly()
    {
        ArrayList<string> list = new ArrayList<string>(10);

        Assert.Empty(list);
        Assert.Equal(10, list.Capacity);
    }

    [Fact]
    public void Constructor_WithNegativeCapacity_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new ArrayList<int>(-1));
    }
}
