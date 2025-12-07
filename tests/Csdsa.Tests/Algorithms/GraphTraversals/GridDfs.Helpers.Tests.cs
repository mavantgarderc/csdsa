using Csdsa.Algorithms.GraphTraversal;

namespace Csdsa.Tests.Algorithms.GraphTraversals;

public sealed partial class GridDfsTests
{
    private static int[,] CreateSimpleIslandGrid()
    {
        // 1 1 0 0
        // 1 0 0 1
        // 0 0 1 1
        // 0 0 0 0
        return new[,]
        {
            { 1, 1, 0, 0 },
            { 1, 0, 0, 1 },
            { 0, 0, 1, 1 },
            { 0, 0, 0, 0 },
        };
    }

    private static int[,] CreateFloodFillGrid()
    {
        // 1 1 0
        // 1 0 0
        // 0 0 1
        return new[,]
        {
            { 1, 1, 0 },
            { 1, 0, 0 },
            { 0, 0, 1 },
        };
    }
}
