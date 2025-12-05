using System.Collections.Generic;
using Csdsa.DataStructures.Lists;
using Xunit;

namespace Csdsa.Tests.DataStructures.Lists;

public class ListTReverseTests
{
    [Fact]
    public void Reverse_ReversesList()
    {
        List<char> list = new List<char> { 'a', 'b', 'c' };

        ListT.Reverse(list);

        Assert.Equal(new[] { 'c', 'b', 'a' }, list);
    }
}
