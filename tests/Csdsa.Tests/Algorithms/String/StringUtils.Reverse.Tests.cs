using Csdsa.Algorithms.Strings;

using Xunit;

namespace Csdsa.Tests.Algorithms.String;

public sealed partial class StringUtilsTests
{
    [Theory]
    [InlineData("abc", "cba")]
    [InlineData("racecar", "racecar")]
    [InlineData("", "")]
    [InlineData("a", "a")]
    public void Reverse_ShouldReturnReversedString(string input, string expected)
    {
        string result = StringUtils.Reverse(input);
        Assert.Equal(expected, result);
    }
}
