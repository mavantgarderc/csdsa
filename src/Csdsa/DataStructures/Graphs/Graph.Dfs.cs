namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides depth-first search operations for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Performs an iterative depth-first search (DFS) starting from the specified vertex.
    /// </summary>
    /// <param name="start">The starting vertex.</param>
    /// <returns>A read-only list of vertices in the order they are visited.</returns>
    public IReadOnlyList<T> DFS(T start)
    {
        List<T> result = new List<T>();
        HashSet<T> visited = new HashSet<T>();
        Stack<T> stack = new Stack<T>();

        if (visited.Add(start))
        {
            stack.Push(start);
        }

        while (stack.Count > 0)
        {
            T node = stack.Pop();
            result.Add(node);

            List<T> neighbors = _adj
                .GetValueOrDefault(node, new List<(T Vertex, int Weight)>())
                .Select(e => e.Vertex)
                .ToList();

            for (int i = neighbors.Count - 1; i >= 0; i--)
            {
                T neighbor = neighbors[i];

                if (visited.Add(neighbor))
                {
                    stack.Push(neighbor);
                }
            }
        }

        return result;
    }

    private void DFSUtil(T node, HashSet<T> visited, List<T> result)
    {
        visited.Add(node);
        result.Add(node);

        foreach ((T neighbor, int _) in _adj.GetValueOrDefault(
                     node,
                     new List<(T Vertex, int Weight)>()))
        {
            if (!visited.Contains(neighbor))
            {
                DFSUtil(neighbor, visited, result);
            }
        }
    }

    /// <summary>
    /// Performs a recursive depth-first search (DFS) starting from the specified vertex.
    /// </summary>
    /// <param name="start">The starting vertex.</param>
    /// <returns>A read-only list of vertices in the order they are visited.</returns>
    public IReadOnlyList<T> DFSRecursive(T start)
    {
        List<T> result = new List<T>();
        HashSet<T> visited = new HashSet<T>();

        DFSUtil(start, visited, result);

        return result;
    }
}
