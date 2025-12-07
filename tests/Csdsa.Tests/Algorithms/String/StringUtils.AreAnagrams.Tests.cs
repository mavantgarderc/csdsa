using Csdsa.Algorithms.Strings;

using Xunit;

namespace Csdsa.Tests.Algorithms.String;

public sealed partial class StringUtilsTests
{
    [Theory]
    [InlineData("listen", "silent", true)]
    [InlineData("hello", "world", false)]
    [InlineData("triangle", "integral", true)]
    [InlineData("rat", "car", false)]
    public void AreAnagrams_ShouldDetectCorrectly(string first, string second, bool expected)
    {
        bool result = StringUtils.AreAnagrams(first, second);
        Assert.Equal(expected, result);
    }
}
