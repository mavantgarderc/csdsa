using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Dfs
{
    /// <summary>
    /// Performs an iterative depth-first traversal of the specified graph
    /// starting from the given source vertex and returns the visitation order.
    /// </summary>
    /// <param name="graph">The graph to traverse.</param>
    /// <param name="source">The source vertex.</param>
    /// <returns>
    /// A read-only list of vertices in the order they were first visited by DFS.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static IReadOnlyList<int> DfsOrder(Graph<int> graph, int source)
    {
        ArgumentNullException.ThrowIfNull(graph);

        List<int> order = new List<int>();
        HashSet<int> visited = new HashSet<int>();
        Stack<int> stack = new Stack<int>();

        stack.Push(source);

        while (stack.Count > 0)
        {
            int u = stack.Pop();

            if (!visited.Add(u))
            {
                continue;
            }

            order.Add(u);

            // Reverse iteration over adjacency to preserve intuitive DFS ordering.
            foreach (int v in graph.Adj[u].AsEnumerable().Reverse())
            {
                if (!visited.Contains(v))
                {
                    stack.Push(v);
                }
            }
        }

        return order;
    }
}
