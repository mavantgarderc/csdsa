using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Bfs
{
    /// <summary>
    /// Computes all connected components of an undirected graph
    /// using BFS.
    /// </summary>
    /// <param name="graph">The graph to inspect.</param>
    /// <returns>
    /// A read-only list of components, each represented by a read-only
    /// list of vertex identifiers.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static IReadOnlyList<IReadOnlyList<int>> ConnectedComponents(Graph<int> graph)
    {
        ArgumentNullException.ThrowIfNull(graph);

        bool[] visited = new bool[graph.VertexCount];
        List<IReadOnlyList<int>> components = new List<IReadOnlyList<int>>();

        foreach (int vertex in graph.Vertices)
        {
            if (!visited[vertex])
            {
                List<int> component = new List<int>();
                Queue<int> queue = new Queue<int>();

                queue.Enqueue(vertex);
                visited[vertex] = true;

                while (queue.Count > 0)
                {
                    int u = queue.Dequeue();
                    component.Add(u);

                    foreach (int v in graph.Adj[u])
                    {
                        if (!visited[v])
                        {
                            visited[v] = true;
                            queue.Enqueue(v);
                        }
                    }
                }

                components.Add(component);
            }
        }

        return components;
    }
}
