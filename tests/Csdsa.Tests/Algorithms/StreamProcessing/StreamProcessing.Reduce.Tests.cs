using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public void Reduce_SumsElements()
    {
        int[] source = { 1, 2, 3 };

        int result = StreamProcessing.Reduce(source, 0, (acc, x) => acc + x);

        Assert.Equal(6, result);
    }
}
