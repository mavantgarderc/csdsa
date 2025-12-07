using System.Collections.Generic;
using System.Threading.Tasks;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public async Task TakeAsync_TakesElements()
    {
        IAsyncEnumerable<int> source = ToAsyncEnumerable(Int32Array1234);

        List<int> result = new List<int>();
        await foreach (int x in StreamProcessing.TakeAsync(source, 2))
        {
            result.Add(x);
        }

        Assert.Equal(new[] { 1, 2 }, result);
    }
}
