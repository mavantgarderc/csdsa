using System.Linq;
using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphNeighborsTests
{
    [Fact]
    public void GetNeighbors_ReturnsEmptyForNonExistentVertex()
    {
        Graph<int> g = new Graph<int>();

        var neighbors = g.GetNeighbors(12345);

        Assert.Empty(neighbors);
    }

    [Fact]
    public void GetNeighborsWithWeights_ReturnsWeights()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(1, 2, 5);
        g.AddEdge(1, 3, 10);

        var neighbors = g.GetNeighborsWithWeights(1);

        Assert.Equal(2, neighbors.Count);
        Assert.Contains((2, 5), neighbors);
        Assert.Contains((3, 10), neighbors);
    }

    [Fact]
    public void Adj_Property_ExposesAdjacencyList()
    {
        Graph<int> g = new Graph<int>();

        g.AddEdge(1, 2);
        g.AddEdge(1, 3);

        var adj = g.Adj;

        Assert.True(adj.ContainsKey(1));
        Assert.Equal(2, adj[1].Count);
        Assert.Contains(2, adj[1]);
        Assert.Contains(3, adj[1]);
    }
}
