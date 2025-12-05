using System.Collections.Generic;
using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListSetRangeTests
{
    private static readonly int[] _expected0980 = { 0, 9, 8, 0 };

    [Fact]
    public void SetRange_ReplacesValues()
    {
        ArrayList<int> list = new ArrayList<int> { 0, 0, 0, 0 };

        list.SetRange(1, new List<int> { 9, 8 });

        Assert.Equal(_expected0980, list.ToArray());
    }
}
