using Csdsa.Algorithms.Strings;

using Xunit;

namespace Csdsa.Tests.Algorithms.String;

public sealed partial class StringUtilsTests
{
    [Theory]
    [InlineData("waterbottle", "erbottlewat", true)]
    [InlineData("rotation", "tationro", true)]
    [InlineData("hello", "elloh", true)]
    [InlineData("hello", "olelh", false)]
    [InlineData("abc", "abcd", false)]
    [InlineData("", "abc", false)]
    [InlineData("abc", "", false)]
    public void IsRotation_ShouldValidateRotation(string original, string rotated, bool expected)
    {
        bool result = StringUtils.IsRotation(original, rotated);
        Assert.Equal(expected, result);
    }
}
