namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="RemoveEdge(T, T)"/> method for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Removes the edge from <paramref name="src"/> to <paramref name="dst"/>,
    /// and the reverse edge for undirected graphs.
    /// </summary>
    /// <param name="src">The source vertex.</param>
    /// <param name="dst">The destination vertex.</param>
    public void RemoveEdge(T src, T dst)
    {
        bool removed = false;

        if (_adj.TryGetValue(src, out List<(T Vertex, int Weight)> srcList))
        {
            removed = srcList.RemoveAll(e => e.Vertex.Equals(dst)) > 0;
        }

        if (!IsDirected && _adj.TryGetValue(dst, out List<(T Vertex, int Weight)> dstList))
        {
            removed |= dstList.RemoveAll(e => e.Vertex.Equals(src)) > 0;
        }

        if (removed)
        {
            MarkDirty();
        }
    }
}
