using System.Collections.Generic;
using Csdsa.DataStructures.Lists;
using Xunit;

namespace Csdsa.Tests.DataStructures.Lists;

public class ListTMergeTests
{
    [Fact]
    public void Merge_CombineBothLists()
    {
        List<int> a = new List<int> { 1, 2 };
        List<int> b = new List<int> { 3, 4 };

        List<int> merged = ListT.Merge(a, b);

        Assert.Equal(new[] { 1, 2, 3, 4 }, merged);
    }
}
