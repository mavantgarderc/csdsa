using System.Collections.Generic;
using System.Threading.Tasks;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public async Task MapAsync_TransformsElements()
    {
        IAsyncEnumerable<int> source = ToAsyncEnumerable(Int32Array123);

        List<int> result = new List<int>();
        await foreach (int x in StreamProcessing.MapAsync(source, y => y * 2))
        {
            result.Add(x);
        }

        Assert.Equal(new[] { 2, 4, 6 }, result);
    }
}
