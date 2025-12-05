namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides breadth-first search for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Performs a breadth-first search (BFS) starting from the specified vertex.
    /// </summary>
    /// <param name="start">The starting vertex.</param>
    /// <returns>A read-only list of vertices in the order they are visited.</returns>
    public IReadOnlyList<T> BFS(T start)
    {
        List<T> result = new List<T>();
        HashSet<T> visited = new HashSet<T>();
        Queue<T> queue = new Queue<T>();

        visited.Add(start);
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            T node = queue.Dequeue();
            result.Add(node);

            foreach ((T neighbor, int _) in _adj.GetValueOrDefault(
                         node,
                         new List<(T Vertex, int Weight)>()))
            {
                if (visited.Add(neighbor))
                {
                    queue.Enqueue(neighbor);
                }
            }
        }

        return result;
    }
}
