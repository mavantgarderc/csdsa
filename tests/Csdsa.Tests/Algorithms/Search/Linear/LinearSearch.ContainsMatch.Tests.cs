using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void ContainsMatch_ReturnsTrue_IfMatchExists()
    {
        string[] collection = { "foo", "bar" };

        bool result = collection.ContainsMatch(s => s == "foo");

        Assert.True(result);
    }

    [Fact]
    public void ContainsMatch_ReturnsFalse_IfNoMatchExists()
    {
        string[] collection = { "foo", "bar" };

        bool result = collection.ContainsMatch(s => s == "baz");

        Assert.False(result);
    }
}
