using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Bfs
{
    /// <summary>
    /// Detects whether the specified undirected graph contains a cycle
    /// using a BFS-based approach.
    /// </summary>
    /// <param name="graph">The undirected graph to inspect.</param>
    /// <returns>
    /// <see langword="true"/> if a cycle is detected; otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static bool DetectCycleUndirected(Graph<int> graph)
    {
        ArgumentNullException.ThrowIfNull(graph);

        bool[] visited = new bool[graph.VertexCount];

        for (int i = 0; i < graph.VertexCount; i++)
        {
            if (!visited[i] && DetectCycleBfs(graph, i, -1, visited))
            {
                return true;
            }
        }

        return false;
    }

    private static bool DetectCycleBfs(Graph<int> graph, int source, int parent, bool[] visited)
    {
        Queue<(int Vertex, int Parent)> queue = new Queue<(int, int)>();
        queue.Enqueue((source, parent));
        visited[source] = true;

        while (queue.Count > 0)
        {
            (int u, int p) = queue.Dequeue();

            foreach (int v in graph.Adj[u])
            {
                if (!visited[v])
                {
                    visited[v] = true;
                    queue.Enqueue((v, u));
                }
                else if (v != p)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
