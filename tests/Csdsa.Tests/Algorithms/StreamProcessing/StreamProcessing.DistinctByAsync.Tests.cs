using System.Collections.Generic;
using System.Threading.Tasks;

using Csdsa.Algorithms.StreamProccessing;

using Xunit;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    [Fact]
    public async Task DistinctByAsync_ReturnsDistinctItems()
    {
        IAsyncEnumerable<string> source = ToAsyncEnumerable(StringArray);

        List<string> result = new List<string>();
        await foreach (string s in StreamProcessing.DistinctByAsync(source, x => x.Length))
        {
            result.Add(s);
        }

        Assert.Contains("a", result);
        Assert.Contains("aa", result);
        Assert.Contains("ccc", result);
        Assert.Equal(3, result.Count);
    }
}
