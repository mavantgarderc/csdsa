using Csdsa.Algorithms.GraphTraversal;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversals;

public sealed partial class GridDfsTests
{
    [Fact]
    public void FloodFill_FillsConnectedRegion()
    {
        int[,] grid = CreateFloodFillGrid();
        Point start = new Point(0, 0);

        GridDfs.FloodFill(grid, start, newColor: 9);

        Assert.Equal(9, grid[0, 0]);
        Assert.Equal(9, grid[0, 1]);
        Assert.Equal(9, grid[1, 0]);

        // Ensure other regions are unchanged.
        Assert.Equal(0, grid[1, 1]);
        Assert.Equal(0, grid[1, 2]);
        Assert.Equal(1, grid[2, 2]);
    }

    [Fact]
    public void FloodFill_DoesNothing_WhenColorIsSame()
    {
        int[,] grid = CreateFloodFillGrid();
        Point start = new Point(0, 0);

        GridDfs.FloodFill(grid, start, newColor: 1);

        // Entire grid should be unchanged.
        Assert.Equal(1, grid[0, 0]);
        Assert.Equal(1, grid[0, 1]);
        Assert.Equal(0, grid[0, 2]);
        Assert.Equal(1, grid[1, 0]);
        Assert.Equal(0, grid[1, 1]);
        Assert.Equal(0, grid[1, 2]);
        Assert.Equal(0, grid[2, 0]);
        Assert.Equal(0, grid[2, 1]);
        Assert.Equal(1, grid[2, 2]);
    }
}
