namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides neighbor access methods for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Gets the neighbors of the specified vertex, ignoring edge weights.
    /// </summary>
    /// <param name="vertex">The vertex whose neighbors to retrieve.</param>
    /// <returns>
    /// A read-only list of neighbor vertices. If the vertex is not present in the graph,
    /// an empty list is returned.
    /// </returns>
    public IReadOnlyList<T> GetNeighbors(T vertex)
    {
        if (_adj.TryGetValue(vertex, out List<(T Vertex, int Weight)> value))
        {
            return value.Select(e => e.Vertex).ToList();
        }

        return new List<T>();
    }

    /// <summary>
    /// Gets the neighbors of the specified vertex along with their edge weights.
    /// </summary>
    /// <param name="vertex">The vertex whose neighbors to retrieve.</param>
    /// <returns>
    /// A read-only list of (neighbor, weight) pairs. If the vertex is not present in the graph,
    /// an empty list is returned.
    /// </returns>
    public IReadOnlyList<(T Vertex, int Weight)> GetNeighborsWithWeights(T vertex)
    {
        if (_adj.TryGetValue(vertex, out List<(T Vertex, int Weight)> value))
        {
            return new List<(T Vertex, int Weight)>(value);
        }

        return new List<(T Vertex, int Weight)>();
    }
}
