namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for two-dimensional arrays.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses a two-dimensional integer array in row-major order and writes each element
    /// to the console.
    /// </summary>
    /// <param name="matrix">The 2D array to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="matrix"/> is <see langword="null"/>.
    /// </exception>
    public static void Traverse2DArray(int[,] matrix)
    {
        if (matrix == null)
        {
            throw new ArgumentNullException(nameof(matrix));
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine(matrix[i, j]);
            }
        }
    }
}
