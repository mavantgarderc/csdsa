using Csdsa.Algorithms.Tuples;

using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void Contains_IdentifiesPresence()
    {
        (int First, string Second) tuple = (1, "x");

        Assert.True(tuple.Contains("x"));
        Assert.False(tuple.Contains("y"));
    }

    [Fact]
    public void IndexOf_ReturnsCorrectIndex()
    {
        (int First, string Second) tuple = (1, "a");

        Assert.Equal(0, tuple.IndexOf(1));
        Assert.Equal(1, tuple.IndexOf("a"));
        Assert.Equal(-1, tuple.IndexOf("z"));
    }
}
