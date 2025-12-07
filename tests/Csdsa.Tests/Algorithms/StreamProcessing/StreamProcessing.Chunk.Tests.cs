using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public void Chunk_GroupsElements()
    {
        int[] source = { 1, 2, 3, 4, 5 };

        List<List<int>> result = StreamProcessing.Chunk(source, 2).ToList();

        Assert.Equal(3, result.Count);
        Assert.Equal(new[] { 1, 2 }, result[0]);
        Assert.Equal(new[] { 3, 4 }, result[1]);
        Assert.Equal(new[] { 5 }, result[2]);
    }
}
