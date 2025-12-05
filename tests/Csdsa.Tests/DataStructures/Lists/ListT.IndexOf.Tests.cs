using System.Collections.Generic;
using Csdsa.DataStructures.Lists;
using Xunit;

namespace Csdsa.Tests.DataStructures.Lists;

public class ListTIndexOfTests
{
    [Fact]
    public void IndexOf_ReturnsCorrectIndex()
    {
        List<char> list = new List<char> { 'x', 'y', 'z' };

        int index = ListT.IndexOf(list, 'y');

        Assert.Equal(1, index);
    }
}
