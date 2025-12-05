namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides methods to enumerate all paths between two vertices in <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Finds all simple paths from <paramref name="start"/> to <paramref name="end"/>.
    /// </summary>
    /// <param name="start">The starting vertex.</param>
    /// <param name="end">The ending vertex.</param>
    /// <returns>
    /// A read-only list of paths, where each path is a read-only list of vertices from start to end.
    /// </returns>
    public IReadOnlyList<IReadOnlyList<T>> FindAllPaths(T start, T end)
    {
        List<IReadOnlyList<T>> paths = new List<IReadOnlyList<T>>();
        List<T> path = new List<T>();

        void Dfs(T node)
        {
            path.Add(node);

            if (node.Equals(end))
            {
                paths.Add(new List<T>(path));
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

            path.RemoveAt(path.Count - 1);
        }

        Dfs(start);
        return paths;
    }
}
