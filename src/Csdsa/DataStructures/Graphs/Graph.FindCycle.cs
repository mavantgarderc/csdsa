namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides cycle retrieval for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Attempts to find a cycle in the graph and returns one such cycle if present.
    /// </summary>
    /// <returns>
    /// A read-only list of vertices representing a cycle, or an empty list if no cycle is found.
    /// </returns>
    public IReadOnlyList<T> FindCycle()
    {
        Dictionary<T, T> parent = new Dictionary<T, T>();
        HashSet<T> recursionStack = new HashSet<T>();
        List<T> cycle = new List<T>();

        bool Dfs(T node)
        {
            recursionStack.Add(node);

            foreach ((T neighbor, int _) in _adj.GetValueOrDefault(
                         node,
                         new List<(T Vertex, int Weight)>()))
            {
                if (!parent.ContainsKey(neighbor))
                {
                    parent[neighbor] = node;

                    if (Dfs(neighbor))
                    {
                        return true;
                    }
                }
                else if (recursionStack.Contains(neighbor))
                {
                    T current = node;
                    cycle.Add(neighbor);

                    while (!current.Equals(neighbor))
                    {
                        cycle.Add(current);
                        current = parent[current];
                    }

                    cycle.Reverse();
                    return true;
                }
            }

            recursionStack.Remove(node);
            return false;
        }

        foreach (T node in _adj.Keys)
        {
            if (!parent.ContainsKey(node))
            {
                parent[node] = default(T);

                if (Dfs(node))
                {
                    return cycle;
                }
            }
        }

        return new List<T>();
    }
}
