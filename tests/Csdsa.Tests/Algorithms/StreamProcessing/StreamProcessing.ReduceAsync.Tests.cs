using System.Threading.Tasks;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public async Task ReduceAsync_SumsElements()
    {
        IAsyncEnumerable<int> source = ToAsyncEnumerable(Int32Array123);

        int sum = await StreamProcessing.ReduceAsync(source, 0, (acc, x) => acc + x);

        Assert.Equal(6, sum);
    }
}
