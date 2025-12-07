using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public void Skip_SkipsElements()
    {
        int[] source = { 1, 2, 3, 4 };

        List<int> result = StreamProcessing.Skip(source, 2).ToList();

        Assert.Equal(new[] { 3, 4 }, result);
    }
}
