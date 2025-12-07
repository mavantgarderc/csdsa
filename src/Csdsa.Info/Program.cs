using System.Diagnostics;
using System.Runtime;
using System.Runtime.InteropServices;
using Csdsa.Algorithms.Strings;
using Csdsa.Algorithms.StreamProccessing;
using Csdsa.DataStructures.Graphs;

namespace Csdsa.Info;

internal static class Program
{
    private static void Main(string[] args)
    {
        PrintHeader();
        PrintEnvironmentInfo();
        RunMicroBenchmarks();
    }

    private static void PrintHeader()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("  Csdsa – Data Structures & Algorithms");
        Console.WriteLine("=======================================");
        Console.WriteLine();

        var asm = typeof(Graph<int>).Assembly.GetName();
        Console.WriteLine($"Assembly : {asm.Name}");
        Console.WriteLine($"Version  : {asm.Version}");
        Console.WriteLine();
    }

    private static void PrintEnvironmentInfo()
    {
        Console.WriteLine("Runtime Environment");
        Console.WriteLine("-------------------");
        Console.WriteLine($".NET Runtime : {RuntimeInformation.FrameworkDescription}");
        Console.WriteLine($"OS          : {RuntimeInformation.OSDescription}");
        Console.WriteLine($"Process Arch: {RuntimeInformation.ProcessArchitecture}");
        Console.WriteLine($"Server GC   : {GCSettings.IsServerGC}");
        Console.WriteLine($"GC Latency  : {GCSettings.LatencyMode}");
        Console.WriteLine();
    }

    private static void RunMicroBenchmarks()
    {
        Console.WriteLine("Micro-benchmarks (approximate)");
        Console.WriteLine("--------------------------------");

        RunGraphBfsBenchmark();
        RunStringKmpBenchmark();
        RunStringZAlgorithmBenchmark();
        RunStreamProcessingSyncBenchmark();
        RunStreamProcessingAsyncBenchmark().GetAwaiter().GetResult();

        Console.WriteLine();
        Console.WriteLine("Note: These numbers are rough and for qualitative insight only.");
    }

    private static void RunGraphBfsBenchmark()
    {
        const int vertexCount = 100_000;

        Graph<int> graph = BuildLinearGraph(vertexCount);

        _ = graph.ShortestPathBFS(0, vertexCount - 1);

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        Stopwatch sw = Stopwatch.StartNew();
        var path = graph.ShortestPathBFS(0, vertexCount - 1);
        sw.Stop();

        Console.WriteLine("Graph BFS");
        Console.WriteLine($"  Vertices          : {vertexCount}");
        Console.WriteLine($"  Path length       : {path.Count}");
        Console.WriteLine($"  Elapsed           : {sw.Elapsed.TotalMilliseconds:F2} ms");
        Console.WriteLine();
    }

    private static Graph<int> BuildLinearGraph(int vertexCount)
    {
        Graph<int> graph = new Graph<int>(isDirected: false);

        for (int i = 0; i < vertexCount; i++)
        {
            graph.AddVertex(i);
        }

        for (int i = 0; i < vertexCount - 1; i++)
        {
            graph.AddEdge(i, i + 1);
        }

        return graph;
    }

    private static void RunStringKmpBenchmark()
    {
        const int repetitions = 20_000;
        const string pattern = "ABABCABAB";
        const string text = "ABABDABACDABABCABAB";

        _ = StringUtils.KmpSearch(pattern, text);

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < repetitions; i++)
        {
            _ = StringUtils.KmpSearch(pattern, text);
        }

        sw.Stop();

        double avgMicroseconds = (sw.Elapsed.TotalMilliseconds * 1_000.0) / repetitions;

        Console.WriteLine("String KMP Search");
        Console.WriteLine($"  Text length       : {text.Length}");
        Console.WriteLine($"  Pattern length    : {pattern.Length}");
        Console.WriteLine($"  Repetitions       : {repetitions:N0}");
        Console.WriteLine($"  Total elapsed     : {sw.Elapsed.TotalMilliseconds:F2} ms");
        Console.WriteLine($"  Avg per search    : {avgMicroseconds:F2} µs");
        Console.WriteLine();
    }

    private static void RunStringZAlgorithmBenchmark()
    {
        const int repetitions = 20_000;
        const string pattern = "abcab";
        const string text = "ababcababcababcababcababc";

        _ = StringUtils.ZAlgorithm(text, pattern);

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < repetitions; i++)
        {
            _ = StringUtils.ZAlgorithm(text, pattern);
        }

        sw.Stop();

        double avgMicroseconds = (sw.Elapsed.TotalMilliseconds * 1_000.0) / repetitions;

        Console.WriteLine("String Z-Algorithm Search");
        Console.WriteLine($"  Text length       : {text.Length}");
        Console.WriteLine($"  Pattern length    : {pattern.Length}");
        Console.WriteLine($"  Repetitions       : {repetitions:N0}");
        Console.WriteLine($"  Total elapsed     : {sw.Elapsed.TotalMilliseconds:F2} ms");
        Console.WriteLine($"  Avg per search    : {avgMicroseconds:F2} µs");
        Console.WriteLine();
    }

    private static void RunStreamProcessingSyncBenchmark()
    {
        const int length = 200_000;
        const int repetitions = 500;

        int[] data = System.Linq.Enumerable.Range(0, length).ToArray();

        IEnumerable<int> warmPipeline =
            StreamProcessing.Take(
                StreamProcessing.Filter(
                    StreamProcessing.Map(data, x => x + 1),
                    x => (x & 1) == 0),
                10_000);

        _ = System.Linq.Enumerable.ToArray(warmPipeline);

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        Stopwatch sw = Stopwatch.StartNew();

        int checksum = 0;

        for (int i = 0; i < repetitions; i++)
        {
            IEnumerable<int> pipeline =
                StreamProcessing.Take(
                    StreamProcessing.Filter(
                        StreamProcessing.Map(data, x => x + 1),
                        x => (x & 1) == 0),
                    10_000);

            foreach (int value in pipeline)
            {
                checksum += value;
            }
        }

        sw.Stop();

        Console.WriteLine("StreamProcessing (sync)");
        Console.WriteLine($"  Length            : {length}");
        Console.WriteLine($"  Repetitions       : {repetitions:N0}");
        Console.WriteLine($"  Total elapsed     : {sw.Elapsed.TotalMilliseconds:F2} ms");
        Console.WriteLine($"  Checksum (ignore) : {checksum}");
        Console.WriteLine();
    }

    private static async Task RunStreamProcessingAsyncBenchmark()
    {
        const int length = 200_000;
        const int repetitions = 200;

        int[] data = System.Linq.Enumerable.Range(0, length).ToArray();

        async IAsyncEnumerable<int> ToAsync(IEnumerable<int> source)
        {
            foreach (int item in source)
            {
                await Task.Yield();
                yield return item;
            }
        }

        IAsyncEnumerable<int> asyncSource = ToAsync(data);

        IAsyncEnumerable<int> warmPipeline =
            StreamProcessing.TakeAsync(
                StreamProcessing.FilterAsync(
                    StreamProcessing.MapAsync(asyncSource, x => x + 1),
                    x => (x & 1) == 0),
                10_000);

        await foreach (int _ in warmPipeline.WithCancellation(CancellationToken.None))
        {
            break;
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        Stopwatch sw = Stopwatch.StartNew();

        int checksum = 0;

        for (int i = 0; i < repetitions; i++)
        {
            IAsyncEnumerable<int> pipeline =
                StreamProcessing.TakeAsync(
                    StreamProcessing.FilterAsync(
                        StreamProcessing.MapAsync(ToAsync(data), x => x + 1),
                        x => (x & 1) == 0),
                    10_000);

            await foreach (int value in pipeline)
            {
                checksum += value;
            }
        }

        sw.Stop();

        Console.WriteLine("StreamProcessing (async)");
        Console.WriteLine($"  Length            : {length}");
        Console.WriteLine($"  Repetitions       : {repetitions:N0}");
        Console.WriteLine($"  Total elapsed     : {sw.Elapsed.TotalMilliseconds:F2} ms");
        Console.WriteLine($"  Checksum (ignore) : {checksum}");
        Console.WriteLine();
    }
}
