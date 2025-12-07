using Csdsa.Algorithms.Strings;

using Xunit;

namespace Csdsa.Tests.Algorithms.String;

public sealed partial class StringUtilsTests
{
    [Theory]
    [InlineData("swiss", 'w')]
    [InlineData("redivider", 'v')]
    [InlineData("aabbcc", null)]
    [InlineData("", null)]
    public void FirstUniqueChar_ShouldReturnCorrectChar(string input, char? expected)
    {
        char? result = StringUtils.FirstUniqueChar(input);
        Assert.Equal(expected, result);
    }
}
