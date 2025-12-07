using Csdsa.Algorithms.Strings;

using Xunit;

namespace Csdsa.Tests.Algorithms.String;

public sealed partial class StringUtilsTests
{
    [Theory]
    [InlineData("RaceCar", true)]
    [InlineData("A man a plan a canal Panama", true)]
    [InlineData("NotAPalindrome", false)]
    public void IsPalindrome_ShouldValidateCorrectly(string input, bool expected)
    {
        bool result = StringUtils.IsPalindrome(input);
        Assert.Equal(expected, result);
    }
}
