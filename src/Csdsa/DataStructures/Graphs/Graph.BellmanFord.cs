namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the Bellman–Ford shortest path algorithm for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Finds a shortest path between two vertices using the Bellman–Ford algorithm,
    /// which supports negative edge weights but not negative cycles.
    /// </summary>
    /// <param name="start">The starting vertex.</param>
    /// <param name="end">The target vertex.</param>
    /// <returns>
    /// A read-only list of vertices representing the path, or an empty list if no path exists.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the graph contains a negative-weight cycle.
    /// </exception>
    public IReadOnlyList<T> BellmanFord(T start, T end)
    {
        Dictionary<T, int> dist = _adj.Keys.ToDictionary(k => k, _ => int.MaxValue);
        Dictionary<T, T> pred = new Dictionary<T, T>();

        dist[start] = 0;

        for (int i = 0; i < _adj.Keys.Count - 1; i++)
        {
            foreach (T u in _adj.Keys)
            {
                if (dist[u] == int.MaxValue)
                {
                    continue;
                }

                foreach ((T neighbor, int weight) in _adj[u])
                {
                    if (dist[u] + weight < dist[neighbor])
                    {
                        dist[neighbor] = dist[u] + weight;
                        pred[neighbor] = u;
                    }
                }
            }
        }

        foreach (T u in _adj.Keys)
        {
            if (dist[u] == int.MaxValue)
            {
                continue;
            }

            foreach ((T neighbor, int weight) in _adj[u])
            {
                if (dist[u] + weight < dist[neighbor])
                {
                    throw new InvalidOperationException("Graph contains a negative-weight cycle.");
                }
            }
        }

        if (!pred.ContainsKey(end))
        {
            return Array.Empty<T>();
        }

        List<T> path = new List<T>();
        T current = end;

        while (pred.ContainsKey(current))
        {
            path.Add(current);
            current = pred[current];
        }

        path.Add(start);
        path.Reverse();

        return path;
    }
}
