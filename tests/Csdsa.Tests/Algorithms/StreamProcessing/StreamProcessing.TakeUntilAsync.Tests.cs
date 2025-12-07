using System.Collections.Generic;
using System.Threading.Tasks;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public async Task TakeUntilAsync_StopsAtPredicate()
    {
        IAsyncEnumerable<int> source = ToAsyncEnumerable(Int32Array12345);

        List<int> result = new List<int>();
        await foreach (int x in StreamProcessing.TakeUntilAsync(source, y => y == 3))
        {
            result.Add(x);
        }

        Assert.Equal(new[] { 1, 2, 3 }, result);
    }
}
