namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides topological sorting for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Performs a topological sort of the graph using DFS.
    /// </summary>
    /// <returns>A read-only list of vertices in topologically sorted order.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the graph contains a cycle.
    /// </exception>
    public IReadOnlyList<T> TopologicalSort()
    {
        HashSet<T> visited = new HashSet<T>();
        HashSet<T> recursionStack = new HashSet<T>();
        List<T> result = new List<T>();

        foreach (T node in _adj.Keys)
        {
            if (!visited.Contains(node))
            {
                DfsForTopSort(node, visited, recursionStack, result);
            }
        }

        result.Reverse();
        return result;
    }

    private void DfsForTopSort(
        T node,
        HashSet<T> visited,
        HashSet<T> recursionStack,
        List<T> result)
    {
        if (recursionStack.Contains(node))
        {
            throw new InvalidOperationException("Graph contains a cycle.");
        }

        if (visited.Contains(node))
        {
            return;
        }

        recursionStack.Add(node);
        visited.Add(node);

        foreach ((T neighbor, int _) in _adj.GetValueOrDefault(
                     node,
                     new List<(T Vertex, int Weight)>()))
        {
            DfsForTopSort(neighbor, visited, recursionStack, result);
        }

        recursionStack.Remove(node);
        result.Add(node);
    }
}
