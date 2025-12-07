using System.Threading.Tasks;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public async Task ForEachAsync_PerformsAction()
    {
        IAsyncEnumerable<int> source = ToAsyncEnumerable(Int32Array123);
        int sum = 0;

        await StreamProcessing.ForEachAsync(source, x => sum += x);

        Assert.Equal(6, sum);
    }
}
