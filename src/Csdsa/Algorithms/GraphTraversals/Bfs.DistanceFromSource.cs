using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Bfs
{
    /// <summary>
    /// Computes the shortest distance from the specified source vertex
    /// to all other vertices in an unweighted graph using BFS.
    /// </summary>
    /// <param name="graph">The graph to traverse.</param>
    /// <param name="source">The source vertex.</param>
    /// <returns>
    /// An array where each entry contains the distance from <paramref name="source"/>
    /// to the corresponding vertex, or -1 if the vertex is unreachable.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static int[] DistanceFromSource(Graph<int> graph, int source)
    {
        ArgumentNullException.ThrowIfNull(graph);

        int[] distances = new int[graph.VertexCount];
        Array.Fill(distances, -1);

        Queue<int> queue = new Queue<int>();

        distances[source] = 0;
        queue.Enqueue(source);

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
