using System.Collections.Generic;
using System.Threading.Tasks;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public async Task PairwiseAsync_ReturnsConsecutivePairs()
    {
        IAsyncEnumerable<int> source = ToAsyncEnumerable(Int32Array123);

        List<(int First, int Second)> result = new List<(int First, int Second)>();
        await foreach ((int First, int Second) pair in StreamProcessing.PairwiseAsync(source))
        {
            result.Add(pair);
        }

        Assert.Equal(new (int, int)[] { (1, 2), (2, 3) }, result);
    }
}
