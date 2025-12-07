using System.Collections.Generic;

using Csdsa.Algorithms.Strings;

using Xunit;

namespace Csdsa.Tests.Algorithms.String;

public sealed partial class StringUtilsTests
{
    [Fact]
    public void ZAlgorithm_ShouldFindAllOccurrences()
    {
        IReadOnlyList<int> result = StringUtils.ZAlgorithm("ababcababcababc", "abc");

        Assert.Equal(new[] { 2, 7, 12 }, result);
    }
}
