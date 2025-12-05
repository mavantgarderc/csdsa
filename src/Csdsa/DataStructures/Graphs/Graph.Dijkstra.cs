namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides Dijkstra's shortest path algorithm for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Finds a shortest path between two vertices in a graph with non-negative edge weights
    /// using Dijkstra's algorithm.
    /// </summary>
    /// <param name="start">The starting vertex.</param>
    /// <param name="end">The target vertex.</param>
    /// <returns>
    /// A read-only list of vertices representing the path, or an empty list if no path exists.
    /// </returns>
    public IReadOnlyList<T> Dijkstra(T start, T end)
    {
        Dictionary<T, int> dist = _adj.Keys.ToDictionary(k => k, _ => int.MaxValue);
        Dictionary<T, T> prev = new Dictionary<T, T>();

        SortedSet<(int Distance, T Vertex)> pq = new SortedSet<(int Distance, T Vertex)>(
            Comparer<(int Distance, T Vertex)>.Create(
                (a, b) =>
                {
                    int cmp = a.Distance.CompareTo(b.Distance);
                    if (cmp == 0)
                    {
                        return a.Vertex.CompareTo(b.Vertex);
                    }

                    return cmp;
                }));

        dist[start] = 0;
        pq.Add((0, start));

        while (pq.Count > 0)
        {
            (int d, T vertex) = pq.Min;
            pq.Remove(pq.Min);

            if (d > dist[vertex])
            {
                continue;
            }

            if (vertex.Equals(end))
            {
                break;
            }

            foreach ((T neighbor, int weight) in _adj.GetValueOrDefault(
                         vertex,
                         new List<(T Vertex, int Weight)>()))
            {
                int newDist = d + weight;

                if (newDist < dist[neighbor])
                {
                    if (dist[neighbor] != int.MaxValue)
                    {
                        pq.Remove((dist[neighbor], neighbor));
                    }

                    dist[neighbor] = newDist;
                    prev[neighbor] = vertex;
                    pq.Add((newDist, neighbor));
                }
            }
        }

        if (!prev.ContainsKey(end))
        {
            return Array.Empty<T>();
        }

        List<T> path = new List<T>();
        T current = end;

        while (prev.ContainsKey(current))
        {
            path.Add(current);
            current = prev[current];
        }

        path.Add(start);
        path.Reverse();
        return path;
    }
}
