using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void IndexOf_FindsFirstMatch()
    {
        int[] collection = { 1, 2, 3, 4, 5 };

        int index = collection.IndexOf(x => x == 4);

        Assert.Equal(3, index);
    }

    [Fact]
    public void IndexOf_ReturnsMinusOne_IfNotFound()
    {
        int[] collection = { 1, 2, 3 };

        int index = collection.IndexOf(x => x == 10);

        Assert.Equal(-1, index);
    }
}
