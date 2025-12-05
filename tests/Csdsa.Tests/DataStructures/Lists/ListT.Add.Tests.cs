using System.Collections.Generic;
using Csdsa.DataStructures.Lists;
using Xunit;

namespace Csdsa.Tests.DataStructures.Lists;

public class ListTAddTests
{
    [Fact]
    public void Add_ElementsToList()
    {
        List<int> list = new List<int>();

        ListT.Add(list, 5);

        Assert.Single(list);
        Assert.Equal(5, list[0]);
    }
}
