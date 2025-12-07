namespace Csdsa.Algorithms.GraphTraversal;

public static partial class GridDfs
{
    /// <summary>
    /// Performs a flood fill on the specified grid starting from the given point,
    /// replacing all connected cells of the original color with the new color.
    /// </summary>
    /// <param name="grid">The grid to modify.</param>
    /// <param name="start">The starting cell for the flood fill.</param>
    /// <param name="newColor">The new color to apply.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="grid"/> is <see langword="null"/>.
    /// </exception>
    public static void FloodFill(int[,] grid, Point start, int newColor)
    {
        ArgumentNullException.ThrowIfNull(grid);

        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        int original = grid[start.X, start.Y];

        if (original == newColor)
        {
            return;
        }

        void DfsInternal(int x, int y)
        {
            if (x < 0 || y < 0 || x >= rows || y >= cols)
            {
                return;
            }

            if (grid[x, y] != original)
            {
                return;
            }

            grid[x, y] = newColor;

            DfsInternal(x + 1, y);
            DfsInternal(x - 1, y);
            DfsInternal(x, y + 1);
            DfsInternal(x, y - 1);
        }

        DfsInternal(start.X, start.Y);
    }
}
