using Csdsa.Algorithms.GraphTraversal;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversals;

public sealed partial class GridDfsTests
{
    [Fact]
    public void NumberOfIslandsDfs_CountsCorrectIslands()
    {
        int[,] grid = CreateSimpleIslandGrid();

        int count = GridDfs.NumberOfIslandsDFS(grid);

        Assert.Equal(2, count);
    }

    [Fact]
    public void NumberOfIslandsDfs_ReturnsZero_WhenNoIslands()
    {
        int[,] grid =
        {
            { 0, 0, 0 },
            { 0, 0, 0 },
        };

        int count = GridDfs.NumberOfIslandsDFS(grid);

        Assert.Equal(0, count);
    }
}
