using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListTrimToSizeTests
{
    [Fact]
    public void TrimToSize_ShrinksCapacity()
    {
        ArrayList<int> list = new ArrayList<int>(16) { 1, 2, 3 };

        list.TrimToSize();

        Assert.Equal(3, list.Capacity);
    }
}
