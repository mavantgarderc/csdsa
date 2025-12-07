using Csdsa.Algorithms.Strings;

using Xunit;

namespace Csdsa.Tests.Algorithms.String;

public sealed partial class StringUtilsTests
{
    [Theory]
    [InlineData("hello world", "world", 6)]
    [InlineData("abcde", "f", -1)]
    [InlineData("banana", "na", 2)]
    public void IndexOfSubstring_ShouldReturnCorrectIndex(string source, string target, int expected)
    {
        int result = StringUtils.IndexOfSubstring(source, target);
        Assert.Equal(expected, result);
    }
}
