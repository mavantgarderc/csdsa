namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides methods to count paths between two vertices in <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Counts the number of simple paths from <paramref name="start"/> to <paramref name="end"/>.
    /// </summary>
    /// <param name="start">The starting vertex.</param>
    /// <param name="end">The ending vertex.</param>
    /// <returns>The number of distinct simple paths.</returns>
    public int CountPaths(T start, T end)
    {
        int count = 0;
        HashSet<T> path = new HashSet<T>();

        void Dfs(T node)
        {
            path.Add(node);

            if (node.Equals(end))
            {
                count++;
            }
            else
            {
                foreach ((T neighbor, int _) in _adj.GetValueOrDefault(
                             node,
                             new List<(T Vertex, int Weight)>()))
                {
                    if (!path.Contains(neighbor))
                    {
                        Dfs(neighbor);
                    }
                }
            }

            path.Remove(node);
        }

        Dfs(start);
        return count;
    }
}
