using System.Collections.Generic;
using Csdsa.DataStructures.Lists;
using Xunit;

namespace Csdsa.Tests.DataStructures.Lists;

public class ListTCloneTests
{
    [Fact]
    public void Clone_ReturnsNewListWithSameElements()
    {
        List<int> original = new List<int> { 10, 20 };

        List<int> clone = ListT.Clone(original);

        Assert.Equal(original, clone);
        Assert.NotSame(original, clone);
    }
}
