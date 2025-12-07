using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using BenchmarkDotNet.Attributes;

using Csdsa.Algorithms.StreamProccessing;

namespace Csdsa.Benchmarks;

[MemoryDiagnoser]
public class StreamProcessingBenchmarks
{
    [Params(10_000, 100_000)]
    public int Length { get; set; }

    private int[] _data = System.Array.Empty<int>();

    [GlobalSetup]
    public void Setup()
    {
        _data = System.Linq.Enumerable.Range(0, Length).ToArray();
    }

    [Benchmark(Description = "Sync pipeline (Map + Filter + Take)")]
    public int SyncPipeline()
    {
        int sum = 0;

        IEnumerable<int> pipeline =
            StreamProcessing.Take(
                StreamProcessing.Filter(
                    StreamProcessing.Map(_data, x => x + 1),
                    x => (x & 1) == 0),
                10_000);

        foreach (int value in pipeline)
        {
            sum += value;
        }

        return sum;
    }

    [Benchmark(Description = "Async pipeline (MapAsync + FilterAsync + TakeAsync)")]
    public async Task<int> AsyncPipeline()
    {
        async IAsyncEnumerable<int> ToAsync()
        {
            foreach (int item in _data)
            {
                // simulate asynchronous source
                await Task.Yield();
                yield return item;
            }
        }

        int sum = 0;

        IAsyncEnumerable<int> pipeline =
            StreamProcessing.TakeAsync(
                StreamProcessing.FilterAsync(
                    StreamProcessing.MapAsync(ToAsync(), x => x + 1),
                    x => (x & 1) == 0),
                10_000);

        await foreach (int value in pipeline.WithCancellation(CancellationToken.None))
        {
            sum += value;
        }

        return sum;
    }
}
