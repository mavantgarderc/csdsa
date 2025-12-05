using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Bfs
{
    /// <summary>
    /// Computes shortest distances from a set of source vertices
    /// to all vertices in an unweighted graph using multi-source BFS.
    /// </summary>
    /// <param name="graph">The graph to traverse.</param>
    /// <param name="sources">The collection of source vertices.</param>
    /// <returns>
    /// An array where each entry contains the distance to the closest source,
    /// or -1 if the vertex is unreachable from all sources.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> or <paramref name="sources"/>
    /// is <see langword="null"/>.
    /// </exception>
    public static int[] MultiSourceBfs(
        Graph<int> graph,
        IReadOnlyList<int> sources)
    {
        ArgumentNullException.ThrowIfNull(graph);
        ArgumentNullException.ThrowIfNull(sources);

        int[] distances = new int[graph.VertexCount];
        Array.Fill(distances, -1);

        Queue<int> queue = new Queue<int>();

        foreach (int source in sources)
        {
            distances[source] = 0;
            queue.Enqueue(source);
        }

        while (queue.Count > 0)
        {
            int u = queue.Dequeue();

            foreach (int v in graph.Adj[u])
            {
                if (distances[v] == -1)
                {
                    distances[v] = distances[u] + 1;
                    queue.Enqueue(v);
                }
            }
        }

        return distances;
    }
}
