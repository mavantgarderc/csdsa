namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="Edges"/> enumeration for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Gets an enumeration of all edges in the graph as (source, destination, weight) tuples.
    /// </summary>
    public IEnumerable<(T Source, T Destination, int Weight)> Edges
    {
        get
        {
            return _adj.SelectMany(
                kvp => kvp.Value.Select(e => (kvp.Key, e.Vertex, e.Weight)));
        }
    }
}
