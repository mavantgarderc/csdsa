using System.Collections.Generic;

using Csdsa.Algorithms.Strings;

using Xunit;

namespace Csdsa.Tests.Algorithms.String;

public sealed partial class StringUtilsTests
{
    [Theory]
    [InlineData("ABABDABACDABABCABAB", "ABABCABAB", new[] { 10 })]
    [InlineData("aaaaa", "aa", new[] { 0, 1, 2, 3 })]
    [InlineData("abcabcabc", "abc", new[] { 0, 3, 6 })]
    [InlineData("abcdef", "gh", new int[0])]
    public void KmpSearch_ShouldReturnExpectedIndices(string text, string pattern, int[] expected)
    {
        IReadOnlyList<int> result = StringUtils.KmpSearch(pattern, text);
        Assert.Equal(expected, result);
    }
}
