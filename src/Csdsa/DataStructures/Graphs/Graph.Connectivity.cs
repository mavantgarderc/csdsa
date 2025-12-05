namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides connectivity operations for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Determines whether the graph is connected (in the undirected sense).
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if all vertices are reachable from an arbitrary start
    /// vertex; otherwise, <see langword="false"/>.
    /// </returns>
    public bool IsGraphConnected()
    {
        if (_adj.Keys.Count == 0)
        {
            return true;
        }

        T start = _adj.Keys.First();
        IReadOnlyList<T> reached = BFS(start);

        return reached.Count == _adj.Keys.Count;
    }

    /// <summary>
    /// Finds all connected components of the graph.
    /// </summary>
    /// <returns>
    /// A read-only list of components, where each component is represented as a list of vertices.
    /// </returns>
    public IReadOnlyList<IReadOnlyList<T>> ConnectedComponents()
    {
        List<IReadOnlyList<T>> components = new List<IReadOnlyList<T>>();
        HashSet<T> visited = new HashSet<T>();

        foreach (T node in _adj.Keys)
        {
            if (visited.Contains(node))
            {
                continue;
            }

            IReadOnlyList<T> component = BFS(node);
            components.Add(component);

            foreach (T vertex in component)
            {
                visited.Add(vertex);
            }
        }

        return components;
    }

    /// <summary>
    /// Counts the number of connected components in the graph.
    /// </summary>
    /// <returns>The number of connected components.</returns>
    public int CountConnectedComponents()
    {
        return ConnectedComponents().Count;
    }
}
