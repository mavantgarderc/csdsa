using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public void Filter_FiltersElements()
    {
        int[] source = { 1, 2, 3, 4 };

        List<int> result = StreamProcessing.Filter(source, x => x % 2 == 0).ToList();

        Assert.Equal(new[] { 2, 4 }, result);
    }
}
