namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides unweighted shortest-path computation (BFS) for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Finds a shortest path (in edge count) between two vertices in an unweighted graph
    /// using breadth-first search.
/// </summary>
/// <param name="start">The starting vertex.</param>
/// <param name="end">The target vertex.</param>
/// <returns>
/// A read-only list of vertices representing the path, or an empty list if no path exists.
/// </returns>
    public IReadOnlyList<T> ShortestPathBFS(T start, T end)
    {
        Dictionary<T, T> parent = new Dictionary<T, T>();
        Queue<T> queue = new Queue<T>();
        HashSet<T> visited = new HashSet<T>();

        queue.Enqueue(start);
        visited.Add(start);
        parent[start] = default(T);

        while (queue.Count > 0)
        {
            T node = queue.Dequeue();

            if (node.Equals(end))
            {
                break;
            }

            foreach ((T neighbor, int _) in _adj.GetValueOrDefault(
                         node,
                         new List<(T Vertex, int Weight)>()))
            {
                if (visited.Add(neighbor))
                {
                    parent[neighbor] = node;
                    queue.Enqueue(neighbor);
                }
            }
        }

        if (!parent.ContainsKey(end))
        {
            return new List<T>();
        }

        List<T> path = new List<T>();
        T current = end;

        while (!current.Equals(start))
        {
            path.Add(current);
            current = parent[current];
        }

        path.Add(start);
        path.Reverse();
        return path;
    }
}
