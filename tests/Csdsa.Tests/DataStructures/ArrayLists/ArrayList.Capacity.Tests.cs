using System;
using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListCapacityTests
{
    [Fact]
    public void Capacity_SetLessThanCount_Throws()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };

        Assert.Throws<ArgumentOutOfRangeException>(() => list.Capacity = 2);
    }
}
