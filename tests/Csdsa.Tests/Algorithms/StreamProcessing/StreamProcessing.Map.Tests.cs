using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public void Map_TransformsElements()
    {
        int[] source = { 1, 2, 3 };

        List<int> result = StreamProcessing.Map(source, x => x * 2).ToList();

        Assert.Equal(new[] { 2, 4, 6 }, result);
    }
}
