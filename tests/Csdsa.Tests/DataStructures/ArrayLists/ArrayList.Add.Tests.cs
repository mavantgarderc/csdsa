using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListAddTests
{
    [Fact]
    public void Add_AppendsElement()
    {
        ArrayList<int> list = new ArrayList<int> { 42 };

        Assert.Single(list);
        Assert.Equal(42, list[0]);
    }
}
