using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public void ForEach_PerformsAction()
    {
        int[] source = { 1, 2, 3 };
        int sum = 0;

        StreamProcessing.ForEach(source, x => sum += x);

        Assert.Equal(6, sum);
    }
}
