using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Bfs
{
    /// <summary>
    /// Performs BFS from the specified source vertex and returns
    /// the depth at which a vertex satisfying the given predicate
    /// is first encountered.
    /// </summary>
    /// <param name="graph">The graph to traverse.</param>
    /// <param name="source">The starting vertex.</param>
    /// <param name="predicate">The predicate to match against visited vertices.</param>
    /// <returns>
    /// The depth of the first vertex satisfying the predicate,
    /// or -1 if no such vertex is reachable.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> or <paramref name="predicate"/>
    /// is <see langword="null"/>.
    /// </exception>
    public static int BfsWithPredicate(
        Graph<int> graph,
        int source,
        Func<int, bool> predicate)
    {
        ArgumentNullException.ThrowIfNull(graph);
        ArgumentNullException.ThrowIfNull(predicate);

        bool[] visited = new bool[graph.VertexCount];
        Queue<(int Vertex, int Depth)> queue = new Queue<(int, int)>();

        queue.Enqueue((source, 0));
        visited[source] = true;

        while (queue.Count > 0)
        {
            (int u, int depth) = queue.Dequeue();

            if (predicate(u))
            {
                return depth;
            }

            foreach (int v in graph.Adj[u])
            {
                if (!visited[v])
                {
                    visited[v] = true;
                    queue.Enqueue((v, depth + 1));
                }
            }
        }

        return -1;
    }
}
