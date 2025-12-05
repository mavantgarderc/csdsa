using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphToJsonAndCloneTests
{
    private static Graph<int> MakeSimplePathGraph()
    {
        Graph<int> g = new Graph<int>();
        g.AddEdge(0, 1, 2);
        g.AddEdge(1, 2, 3);
        g.AddEdge(2, 3, 4);
        return g;
    }

    [Fact]
    public void ToJson_ProducesValidJson()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(1, 2, 3);

        string json = g.ToJson();

        Assert.Contains("IsDirected", json);
        Assert.Contains("Vertices", json);
        Assert.Contains("Edges", json);
    }

    [Fact]
    public void Clone_CreatesIdenticalGraph()
    {
        Graph<int> g = MakeSimplePathGraph();

        Graph<int> clone = g.Clone();

        Assert.Equal(g.VertexCount, clone.VertexCount);
        Assert.Equal(g.EdgeCount, clone.EdgeCount);
        Assert.Equal(g.IsDirected, clone.IsDirected);

        foreach (int vertex in g.Vertices)
        {
            Assert.Equal(g.GetNeighbors(vertex), clone.GetNeighbors(vertex));
        }
    }
}
