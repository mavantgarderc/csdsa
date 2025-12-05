using System;
using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListForEachTests
{
    [Fact]
    public void ForEach_ExecutesActionOnAllElements()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };
        int sum = 0;

        list.ForEach(x => sum += x);

        Assert.Equal(6, sum);
    }

    [Fact]
    public void ForEach_EmptyList_DoesNothing()
    {
        ArrayList<int> list = new ArrayList<int>();
        bool executed = false;

        list.ForEach(x => executed = true);

        Assert.False(executed);
    }

    [Fact]
    public void ForEach_DetectsModification_Throws()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };

        Assert.Throws<InvalidOperationException>(
            () => list.ForEach(x =>
            {
                if (x == 2)
                {
                    list.Add(4);
                }
            }));
    }
}
