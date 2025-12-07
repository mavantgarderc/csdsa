using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public void TakeUntil_StopsAtPredicate()
    {
        int[] source = { 1, 2, 3, 4, 5 };

        List<int> result = StreamProcessing.TakeUntil(source, x => x == 3).ToList();

        Assert.Equal(new[] { 1, 2, 3 }, result);
    }
}
