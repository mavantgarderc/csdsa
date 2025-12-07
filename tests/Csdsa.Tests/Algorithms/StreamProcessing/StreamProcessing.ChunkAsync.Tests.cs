using System.Collections.Generic;
using System.Threading.Tasks;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public async Task ChunkAsync_GroupsElements()
    {
        IAsyncEnumerable<int> source = ToAsyncEnumerable(Int32Array12345);

        List<List<int>> result = new List<List<int>>();
        await foreach (List<int> chunk in StreamProcessing.ChunkAsync(source, 2))
        {
            result.Add(chunk);
        }

        Assert.Equal(3, result.Count);
        Assert.Equal(new[] { 1, 2 }, result[0]);
        Assert.Equal(new[] { 3, 4 }, result[1]);
        Assert.Equal(new[] { 5 }, result[2]);
    }
}
