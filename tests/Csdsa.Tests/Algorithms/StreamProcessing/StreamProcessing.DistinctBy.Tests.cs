using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public void DistinctBy_ReturnsDistinctItems()
    {
        string[] source = { "a", "aa", "b", "bb", "ccc" };

        List<string> result = StreamProcessing.DistinctBy(source, s => s.Length).ToList();

        Assert.Contains("a", result);
        Assert.Contains("aa", result);
        Assert.Contains("ccc", result);
        Assert.Equal(3, result.Count);
    }
}
