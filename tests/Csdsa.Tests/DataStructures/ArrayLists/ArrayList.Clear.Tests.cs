using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListClearTests
{
    [Fact]
    public void Clear_EmptiesTheList()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };

        list.Clear();

        Assert.Empty(list);
    }
}
