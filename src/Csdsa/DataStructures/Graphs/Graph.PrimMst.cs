namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides Prim's minimum spanning tree algorithm for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Computes a minimum spanning tree (MST) using Prim's algorithm.
    /// </summary>
    /// <returns>
    /// A read-only list of edges (source, destination, weight) that form the MST.
    /// </returns>
    public IReadOnlyList<(T Source, T Destination, int Weight)> PrimMST()
    {
        if (_adj.Count == 0)
        {
            return new List<(T Source, T Destination, int Weight)>();
        }

        HashSet<T> inMst = new HashSet<T>();

        SortedSet<(int Weight, T Source, T Destination)> pq =
            new SortedSet<(int Weight, T Source, T Destination)>(
                Comparer<(int Weight, T Source, T Destination)>.Create(
                    (a, b) =>
                    {
                        int cmp = a.Weight.CompareTo(b.Weight);
                        if (cmp == 0)
                        {
                            cmp = a.Source.CompareTo(b.Source);
                        }

                        if (cmp == 0)
                        {
                            cmp = a.Destination.CompareTo(b.Destination);
                        }

                        return cmp;
                    }));

        T start = _adj.Keys.First();
        inMst.Add(start);

        foreach ((T neighbor, int weight) in _adj[start])
        {
            pq.Add((weight, start, neighbor));
        }

        List<(T Source, T Destination, int Weight)> mst =
            new List<(T Source, T Destination, int Weight)>();

        while (pq.Count > 0 && inMst.Count < _adj.Keys.Count)
        {
            (int weight, T source, T destination) = pq.Min;
            pq.Remove(pq.Min);

            if (inMst.Contains(destination))
            {
                continue;
            }

            inMst.Add(destination);
            mst.Add((source, destination, weight));

            foreach ((T neighbor, int w) in _adj[destination])
            {
                if (!inMst.Contains(neighbor))
                {
                    pq.Add((w, destination, neighbor));
                }
            }
        }

        return mst;
    }
}
