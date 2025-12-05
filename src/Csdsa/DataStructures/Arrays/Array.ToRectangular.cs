namespace Csdsa.DataStructures.Arrays;

public static partial class ArrayUtils
{
    /// <summary>
    /// Converts a jagged array to a rectangular two-dimensional array.
    /// </summary>
    /// <typeparam name="T">The element type of the array.</typeparam>
    /// <param name="jaggedArray">The jagged array to convert.</param>
    /// <returns>
    /// A new two-dimensional array containing the same elements as
    /// <paramref name="jaggedArray"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="jaggedArray"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="jaggedArray"/> is not rectangular
    /// (rows have differing lengths).
    /// </exception>
    public static T[,] ToRectangular<T>(T[][] jaggedArray)
    {
        ArgumentNullException.ThrowIfNull(jaggedArray);

        int rows = jaggedArray.Length;
        int cols = jaggedArray[0].Length;

        for (int i = 1; i < rows; i++)
        {
            if (jaggedArray[i].Length != cols)
            {
                throw new ArgumentException("Jagged array is not rectangular.");
            }
        }

        T[,] result = new T[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = jaggedArray[i][j];
            }
        }

        return result;
    }
}
