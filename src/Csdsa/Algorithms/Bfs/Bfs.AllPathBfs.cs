using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Bfs
{
    /// <summary>
    /// Enumerates all simple paths between the specified source and destination
    /// in a graph using BFS, up to a maximum path length.
    /// </summary>
    /// <param name="graph">The graph to traverse.</param>
    /// <param name="source">The source vertex.</param>
    /// <param name="destination">The destination vertex.</param>
    /// <param name="maxDepth">The maximum allowed path length.</param>
    /// <returns>
    /// A read-only collection of paths, where each path is represented
    /// as a read-only collection of vertices.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static IReadOnlyList<IReadOnlyList<int>> AllPathsBfs(
        Graph<int> graph,
        int source,
        int destination,
        int maxDepth)
    {
        ArgumentNullException.ThrowIfNull(graph);

        List<IReadOnlyList<int>> paths = new List<IReadOnlyList<int>>();
        Queue<List<int>> queue = new Queue<List<int>>();

        queue.Enqueue(new List<int> { source });

        while (queue.Count > 0)
        {
            List<int> path = queue.Dequeue();

            if (path[^1] == destination && path.Count <= maxDepth)
            {
                paths.Add(new List<int>(path));
            }

            if (path.Count >= maxDepth)
            {
                continue;
            }

            foreach (int v in graph.Adj[path[^1]])
            {
                List<int> newPath = new List<int>(path) { v };
                queue.Enqueue(newPath);
            }
        }

        return paths;
    }
}
