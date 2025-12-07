using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using Csdsa.DataStructures.Graphs;

namespace Csdsa.Benchmarks;

[MemoryDiagnoser]
public class GraphBfsBenchmarks
{
    [Params(10_000, 50_000, 100_000)]
    public int VertexCount { get; set; }

    private Graph<int> _linearGraph = null!;

    [GlobalSetup]
    public void Setup()
    {
        _linearGraph = new Graph<int>(isDirected: false);

        for (int i = 0; i < VertexCount; i++)
        {
            _linearGraph.AddVertex(i);
        }

        for (int i = 0; i < VertexCount - 1; i++)
        {
            _linearGraph.AddEdge(i, i + 1);
        }
    }

    [Benchmark(Description = "ShortestPathBFS(linear)")]
    public IReadOnlyList<int> ShortestPathBfs_Linear()
    {
        return _linearGraph.ShortestPathBFS(0, VertexCount - 1);
    }
}
