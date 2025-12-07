using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Dfs
{
    /// <summary>
    /// Enumerates all simple paths between the specified source and destination
    /// vertices using recursive DFS, up to a maximum path length.
    /// </summary>
    /// <param name="graph">The graph to search.</param>
    /// <param name="source">The source vertex.</param>
    /// <param name="destination">The destination vertex.</param>
    /// <param name="maxDepth">
    /// The maximum allowed path length (number of vertices). Defaults to <see cref="int.MaxValue"/>.
    /// </param>
    /// <returns>
    /// A read-only list of paths, where each path is represented as a read-only
    /// list of vertices.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static IReadOnlyList<IReadOnlyList<int>> AllPathsDFS(
        Graph<int> graph,
        int source,
        int destination,
        int maxDepth = int.MaxValue)
    {
        ArgumentNullException.ThrowIfNull(graph);

        List<IReadOnlyList<int>> result = new List<IReadOnlyList<int>>();
        List<int> path = new List<int>();

        void DfsInternal(int u, int depth)
        {
            path.Add(u);

            if (u == destination && path.Count <= maxDepth)
            {
                result.Add(new List<int>(path));
            }
            else if (depth < maxDepth)
            {
                foreach (int v in graph.Adj[u])
                {
                    if (!path.Contains(v))
                    {
                        DfsInternal(v, depth + 1);
                    }
                }
            }

            path.RemoveAt(path.Count - 1);
        }

        DfsInternal(source, 1);
        return result;
    }
}
