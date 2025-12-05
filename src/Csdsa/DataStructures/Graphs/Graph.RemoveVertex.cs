namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="RemoveVertex(T)"/> method for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Removes a vertex and all incident edges from the graph.
    /// </summary>
    /// <param name="vertex">The vertex to remove.</param>
    public void RemoveVertex(T vertex)
    {
        if (_adj.Remove(vertex))
        {
            foreach (KeyValuePair<T, List<(T Vertex, int Weight)>> kvp in _adj)
            {
                kvp.Value.RemoveAll(e => e.Vertex.Equals(vertex));
            }

            MarkDirty();
        }
    }
}
