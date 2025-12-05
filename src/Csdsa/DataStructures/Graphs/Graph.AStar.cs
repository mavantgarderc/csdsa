namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides A* shortest path algorithm for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Finds a shortest path between two vertices using the A* algorithm.
    /// </summary>
    /// <param name="start">The starting vertex.</param>
    /// <param name="end">The target vertex.</param>
    /// <param name="heuristic">
    /// An optional heuristic function estimating the distance between two vertices.
    /// If <see langword="null"/>, zero is used (reducing to Dijkstra's algorithm).
    /// </param>
    /// <returns>
    /// A read-only list of vertices representing the path, or an empty list if no path exists.
    /// </returns>
    public IReadOnlyList<T> AStar(T start, T end, Func<T, T, int> heuristic = null)
    {
        heuristic ??= (_, __) => 0;

        Dictionary<T, int> gScore = _adj.Keys.ToDictionary(k => k, _ => int.MaxValue);
        Dictionary<T, int> fScore = _adj.Keys.ToDictionary(k => k, _ => int.MaxValue);
        Dictionary<T, T> cameFrom = new Dictionary<T, T>();

        gScore[start] = 0;
        fScore[start] = heuristic(start, end);

        SortedSet<(int Score, T Vertex)> open = new SortedSet<(int Score, T Vertex)>(
            Comparer<(int Score, T Vertex)>.Create(
                (a, b) =>
                {
                    int cmp = a.Score.CompareTo(b.Score);
                    if (cmp == 0)
                    {
                        return a.Vertex.CompareTo(b.Vertex);
                    }

                    return cmp;
                }));

        open.Add((fScore[start], start));

        while (open.Count > 0)
        {
            (int currentScore, T current) = open.Min;

            if (current.Equals(end))
            {
                break;
            }

            open.Remove(open.Min);

            foreach ((T neighbor, int weight) in _adj.GetValueOrDefault(
                         current,
                         new List<(T Vertex, int Weight)>()))
            {
                int tentativeG = gScore[current] + weight;

                if (tentativeG < gScore[neighbor])
                {
                    gScore[neighbor] = tentativeG;
                    fScore[neighbor] = tentativeG + heuristic(neighbor, end);
                    cameFrom[neighbor] = current;

                    (int Score, T Vertex) candidate = (fScore[neighbor], neighbor);
                    open.Add(candidate);
                }
            }
        }

        if (!cameFrom.ContainsKey(end))
        {
            return Array.Empty<T>();
        }

        List<T> path = new List<T>();
        T node = end;

        while (cameFrom.ContainsKey(node))
        {
            path.Add(node);
            node = cameFrom[node];
        }

        path.Add(start);
        path.Reverse();
        return path;
    }
}
