using System.Collections.Generic;
using System.Threading.Tasks;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public async Task FilterAsync_FiltersElements()
    {
        IAsyncEnumerable<int> source = ToAsyncEnumerable(Int32Array1234);

        List<int> result = new List<int>();
        await foreach (int x in StreamProcessing.FilterAsync(source, y => y % 2 == 0))
        {
            result.Add(x);
        }

        Assert.Equal(new[] { 2, 4 }, result);
    }
}
