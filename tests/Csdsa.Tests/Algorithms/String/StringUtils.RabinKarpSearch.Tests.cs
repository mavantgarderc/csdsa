using System.Collections.Generic;

using Csdsa.Algorithms.Strings;

using Xunit;

namespace Csdsa.Tests.Algorithms.String;

public sealed partial class StringUtilsTests
{
    [Fact]
    public void RabinKarpSearch_ShouldReturnCorrectMatchPositions()
    {
        IReadOnlyList<int> result = StringUtils.RabinKarpSearch("xyzxyzxyz", "xyz");

        Assert.Equal(new[] { 0, 3, 6 }, result);
    }
}
