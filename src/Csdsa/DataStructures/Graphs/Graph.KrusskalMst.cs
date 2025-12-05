namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides Kruskal's minimum spanning tree algorithm for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Computes a minimum spanning tree (MST) using Kruskal's algorithm.
    /// </summary>
    /// <returns>
    /// A read-only list of edges (source, destination, weight) that form the MST.
    /// </returns>
    public IReadOnlyList<(T Source, T Destination, int Weight)> KruskalMST()
    {
        List<(T Source, T Destination, int Weight)> edges = _adj
            .SelectMany(kvp => kvp.Value.Select(e => (kvp.Key, e.Vertex, e.Weight)))
            .ToList();

        edges.Sort((a, b) => a.Weight.CompareTo(b.Weight));

        Dictionary<T, T> parent = _adj.Keys.ToDictionary(k => k, k => k);

        T Find(T x)
        {
            if (!parent[x].Equals(x))
            {
                parent[x] = Find(parent[x]);
            }

            return parent[x];
        }

        void Union(T a, T b)
        {
            T rootA = Find(a);
            T rootB = Find(b);

            if (!rootA.Equals(rootB))
            {
                parent[rootB] = rootA;
            }
        }

        List<(T Source, T Destination, int Weight)> mst =
            new List<(T Source, T Destination, int Weight)>();

        foreach ((T u, T v, int w) in edges)
        {
            if (!Find(u).Equals(Find(v)))
            {
                mst.Add((u, v, w));
                Union(u, v);
            }
        }

        return mst;
    }
}
