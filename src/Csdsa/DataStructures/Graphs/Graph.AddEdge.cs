namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="AddEdge(T, T, int)"/> method for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Adds a weighted edge from <paramref name="src"/> to <paramref name="dst"/>.
    /// </summary>
    /// <param name="src">The source vertex.</param>
    /// <param name="dst">The destination vertex.</param>
    /// <param name="weight">The weight of the edge.</param>
    public void AddEdge(T src, T dst, int weight = 1)
    {
        AddVertex(src);
        AddVertex(dst);

        if (!_adj[src].Any(e => e.Vertex.Equals(dst)))
        {
            _adj[src].Add((dst, weight));

            if (!IsDirected && !src.Equals(dst))
            {
                _adj[dst].Add((src, weight));
            }

            MarkDirty();
        }
    }
}
