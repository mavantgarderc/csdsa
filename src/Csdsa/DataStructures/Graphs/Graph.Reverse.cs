namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="ReverseGraph"/> method for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Reverses the direction of all edges in the graph.
    /// </summary>
    public void ReverseGraph()
    {
        Dictionary<T, List<(T Vertex, int Weight)>> reversed =
            new Dictionary<T, List<(T Vertex, int Weight)>>();

        foreach (KeyValuePair<T, List<(T Vertex, int Weight)>> kvp in _adj)
        {
            T src = kvp.Key;

            foreach ((T dst, int weight) in kvp.Value)
            {
                if (!reversed.TryGetValue(dst, out List<(T Vertex, int Weight)> list))
                {
                    list = new List<(T Vertex, int Weight)>();
                    reversed[dst] = list;
                }

                list.Add((src, weight));
            }
        }

        _adj.Clear();

        foreach (KeyValuePair<T, List<(T Vertex, int Weight)>> kvp in reversed)
        {
            _adj[kvp.Key] = kvp.Value;
        }

        MarkDirty();
    }
}
