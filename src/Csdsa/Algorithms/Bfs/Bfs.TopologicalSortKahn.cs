using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Bfs
{
    /// <summary>
    /// Performs a topological sort of a directed acyclic graph (DAG)
    /// using Kahn's algorithm (BFS on indegree).
    /// </summary>
    /// <param name="graph">The directed graph to sort.</param>
    /// <returns>
    /// A read-only list representing a topological ordering of the vertices,
    /// or an empty array if the graph contains a cycle.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static IReadOnlyList<int> TopologicalSortKahn(Graph<int> graph)
    {
        ArgumentNullException.ThrowIfNull(graph);

        int[] inDegree = new int[graph.VertexCount];

        foreach (int u in graph.Vertices)
        {
            foreach (int v in graph.Adj[u])
            {
                inDegree[v]++;
            }
        }

        Queue<int> queue = new Queue<int>();

        foreach (int vertex in graph.Vertices)
        {
            if (inDegree[vertex] == 0)
            {
                queue.Enqueue(vertex);
            }
        }

        List<int> ordering = new List<int>();

        while (queue.Count > 0)
        {
            int u = queue.Dequeue();
            ordering.Add(u);

            foreach (int v in graph.Adj[u])
            {
                inDegree[v]--;

                if (inDegree[v] == 0)
                {
                    queue.Enqueue(v);
                }
            }
        }

        if (ordering.Count != graph.VertexCount)
        {
            return Array.Empty<int>();
        }

        return ordering;
    }
}
