using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListEnsureCapacityTests
{
    [Fact]
    public void EnsureCapacity_ExpandsStorage()
    {
        ArrayList<int> list = new ArrayList<int>(1);

        list.Add(1);
        list.EnsureCapacity(10);

        Assert.True(list.Capacity >= 10);
    }
}
