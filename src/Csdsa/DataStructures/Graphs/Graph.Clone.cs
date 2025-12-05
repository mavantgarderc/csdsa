namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="Clone"/> method for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Creates a deep copy of the graph, including all vertices and edges.
    /// </summary>
    /// <returns>A new <see cref="Graph{T}"/> instance with the same structure.</returns>
    public Graph<T> Clone()
    {
        Graph<T> clone = new Graph<T>(IsDirected);

        foreach ((T source, T destination, int weight) in Edges)
        {
            clone.AddEdge(source, destination, weight);
        }

        return clone;
    }
}
