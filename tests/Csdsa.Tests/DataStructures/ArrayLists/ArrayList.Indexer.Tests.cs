using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListIndexerTests
{
    [Fact]
    public void Indexer_GetSet_Works()
    {
        ArrayList<string> list = new ArrayList<string> { "first" };

        list[0] = "updated";

        Assert.Equal("updated", list[0]);
    }
}
