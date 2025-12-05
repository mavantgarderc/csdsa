namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="Vertices"/> enumeration for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Gets an enumeration of all vertices in the graph.
    /// </summary>
    public IEnumerable<T> Vertices
    {
        get { return _adj.Keys; }
    }
}
