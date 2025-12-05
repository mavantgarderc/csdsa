using System;
using System.Collections.Generic;
using Csdsa.DataStructures.Graphs;
using Xunit;

namespace Csdsa.Tests.DataStructures.Graphs;

public class GraphGraphColoringTests
{
    [Fact]
    public void GraphColoring_AssignsColorsCorrectly()
    {
        Graph<char> graph = new Graph<char>();

        graph.AddEdge('A', 'B');
        graph.AddEdge('B', 'C');

        Dictionary<char, int> colors = graph.GraphColoring(3);

        Assert.Equal(0, colors['A']);
        Assert.NotEqual(colors['A'], colors['B']);
        Assert.NotEqual(colors['B'], colors['C']);
    }

    [Fact]
    public void GraphColoring_HandlesDisconnectedGraph()
    {
        Graph<char> graph = new Graph<char>();

        graph.AddVertex('X');
        graph.AddVertex('Y');
        graph.AddVertex('Z');

        Dictionary<char, int> colors = graph.GraphColoring(1);

        Assert.Equal(0, colors['X']);
        Assert.Equal(0, colors['Y']);
        Assert.Equal(0, colors['Z']);
    }

    [Fact]
    public void GraphColoring_ThrowsOnImpossible()
    {
        Graph<char> graph = new Graph<char>();

        graph.AddEdge('A', 'B');
        graph.AddEdge('B', 'C');
        graph.AddEdge('C', 'A');

        Exception ex = Record.Exception(() => graph.GraphColoring(2));

        Assert.NotNull(ex);
        Assert.Contains("Impossible Coloring", ex.Message);
    }

    [Fact]
    public void GraphColoring_AllowsMaxColorUse()
    {
        Graph<int> graph = new Graph<int>();

        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);

        Dictionary<int, int> colors = graph.GraphColoring(2);

        foreach (int node in graph.Vertices)
        {
            foreach (int neighbor in graph.GetNeighbors(node))
            {
                Assert.NotEqual(colors[node], colors[neighbor]);
            }
        }
    }
}
