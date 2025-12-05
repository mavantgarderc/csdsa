namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides edge existence checks for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Determines whether an edge exists from <paramref name="a"/> to <paramref name="b"/>.
    /// </summary>
    /// <param name="a">The source vertex.</param>
    /// <param name="b">The destination vertex.</param>
    /// <returns>
    /// <see langword="true"/> if an edge exists; otherwise, <see langword="false"/>.
    /// </returns>
    public bool HasEdge(T a, T b)
    {
        return _adj.ContainsKey(a) && _adj[a].Any(e => e.Vertex.Equals(b));
    }

    /// <summary>
    /// Determines whether two vertices are connected by a direct edge
    /// from <paramref name="a"/> to <paramref name="b"/>.
    /// </summary>
    /// <param name="a">The source vertex.</param>
    /// <param name="b">The destination vertex.</param>
    /// <returns>
    /// <see langword="true"/> if the vertices are connected by an edge; otherwise,
    /// <see langword="false"/>.
    /// </returns>
    public bool IsConnected(T a, T b)
    {
        return HasEdge(a, b);
    }
}
