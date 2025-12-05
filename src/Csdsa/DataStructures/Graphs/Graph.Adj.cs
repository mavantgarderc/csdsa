namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides adjacency accessors for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Gets a copy of the graph as an adjacency list of vertices only,
    /// ignoring edge weights.
    /// <para>
    /// This is useful for algorithms that expect a <c>List&lt;T&gt;</c>-style
    /// neighbor representation.
    /// </para>
    /// </summary>
    public Dictionary<T, List<T>> Adj
    {
        get
        {
            Dictionary<T, List<T>> dict = new Dictionary<T, List<T>>();

            foreach (KeyValuePair<T, List<(T Vertex, int Weight)>> kvp in _adj)
            {
                dict[kvp.Key] = kvp.Value.Select(e => e.Vertex).ToList();
            }

            return dict;
        }
    }
}
