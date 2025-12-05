using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListInsertTests
{
    private static readonly int[] _expected123 = { 1, 2, 3 };

    [Fact]
    public void Insert_InsertsAtCorrectIndex()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 3 };

        list.Insert(1, 2);

        Assert.Equal(_expected123, list.ToArray());
    }
}
