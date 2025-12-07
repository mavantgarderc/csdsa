using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public void Pairwise_ReturnsConsecutivePairs()
    {
        int[] source = { 1, 2, 3 };

        List<(int First, int Second)> result = StreamProcessing.Pairwise(source).ToList();

        Assert.Equal(new (int, int)[] { (1, 2), (2, 3) }, result);
    }
}
