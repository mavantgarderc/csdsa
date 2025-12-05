namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides cycle detection for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Determines whether the graph contains any cycle.
    /// Uses a directed or undirected algorithm based on <see cref="IsDirected"/>.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if the graph contains a cycle; otherwise, <see langword="false"/>.
    /// </returns>
    public bool HasCycle()
    {
        if (IsDirected)
        {
            return HasCycleDirectedHelper();
        }

        return HasCycleUndirectedHelper();
    }

    private bool HasCycleDirectedHelper()
    {
        HashSet<T> visited = new HashSet<T>();
        HashSet<T> recursionStack = new HashSet<T>();

        bool Dfs(T node)
        {
            if (recursionStack.Contains(node))
            {
                return true;
            }

            if (visited.Contains(node))
            {
                return false;
            }

            visited.Add(node);
            recursionStack.Add(node);

            foreach ((T neighbor, int _) in _adj.GetValueOrDefault(
                         node,
                         new List<(T Vertex, int Weight)>()))
            {
                if (Dfs(neighbor))
                {
                    return true;
                }
            }

            recursionStack.Remove(node);
            return false;
        }

        foreach (T node in _adj.Keys)
        {
            if (Dfs(node))
            {
                return true;
            }
        }

        return false;
    }

    private bool HasCycleUndirectedHelper()
    {
        HashSet<T> visited = new HashSet<T>();

        bool Dfs(T node, T parent)
        {
            visited.Add(node);

            foreach ((T neighbor, int _) in _adj.GetValueOrDefault(
                         node,
                         new List<(T Vertex, int Weight)>()))
            {
                if (!visited.Contains(neighbor))
                {
                    if (Dfs(neighbor, node))
                    {
                        return true;
                    }
                }
                else if (!neighbor.Equals(parent))
                {
                    return true;
                }
            }

            return false;
        }

        foreach (T node in _adj.Keys)
        {
            if (!visited.Contains(node))
            {
                if (Dfs(node, default(T)))
                {
                    return true;
                }
            }
        }

        return false;
    }

    /// <summary>
    /// Obsolete. Use <see cref="HasCycle"/> instead.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if the directed graph contains a cycle; otherwise,
    /// <see langword="false"/>.
    /// </returns>
    [Obsolete("Use HasCycle instead.")]
    public bool HasCycleDirected()
    {
        return HasCycle();
    }
}
