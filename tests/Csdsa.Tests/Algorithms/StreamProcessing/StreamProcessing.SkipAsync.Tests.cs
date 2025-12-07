using System.Collections.Generic;
using System.Threading.Tasks;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public async Task SkipAsync_SkipsElements()
    {
        IAsyncEnumerable<int> source = ToAsyncEnumerable(Int32Array1234);

        List<int> result = new List<int>();
        await foreach (int x in StreamProcessing.SkipAsync(source, 2))
        {
            result.Add(x);
        }

        Assert.Equal(new[] { 3, 4 }, result);
    }
}
