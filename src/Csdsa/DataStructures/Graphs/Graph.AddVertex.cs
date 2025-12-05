namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="AddVertex(T)"/> method for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Adds a vertex to the graph if it does not already exist.
    /// </summary>
    /// <param name="vertex">The vertex to add.</param>
    public void AddVertex(T vertex)
    {
        if (!_adj.ContainsKey(vertex))
        {
            _adj[vertex] = new List<(T Vertex, int Weight)>();
            MarkDirty();
        }
    }
}
