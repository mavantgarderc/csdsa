using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Dfs
{
    /// <summary>
    /// Computes the connected components of an undirected graph using DFS.
    /// </summary>
    /// <param name="graph">The undirected graph to inspect.</param>
    /// <returns>
    /// A read-only list of components, each represented by a read-only list of vertices.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static IReadOnlyList<IReadOnlyList<int>> ConnectedComponents(Graph<int> graph)
    {
        ArgumentNullException.ThrowIfNull(graph);

        HashSet<int> visited = new HashSet<int>();
        List<IReadOnlyList<int>> components = new List<IReadOnlyList<int>>();

        foreach (int u in graph.Adj.Keys)
        {
            if (visited.Contains(u))
            {
                continue;
            }

            List<int> component = new List<int>();

            void DfsInternal(int v)
            {
                visited.Add(v);
                component.Add(v);

                foreach (int w in graph.Adj[v])
                {
                    if (!visited.Contains(w))
                    {
                        DfsInternal(w);
                    }
                }
            }

            DfsInternal(u);
            components.Add(component);
        }

        return components;
    }
}
