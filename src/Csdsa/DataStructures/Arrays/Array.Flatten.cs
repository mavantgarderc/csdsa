using System;

namespace Csdsa.DataStructures.Arrays;

/// <summary>
/// Provides methods for flattening multidimensional arrays.
/// </summary>
public static partial class ArrayUtils
{
    /// <summary>
    /// Flattens a two-dimensional rectangular array into a one-dimensional array.
    /// </summary>
    /// <typeparam name="T">The element type of the array.</typeparam>
    /// <param name="multiArray">The two-dimensional array to flatten.</param>
    /// <returns>
    /// A new one-dimensional array containing the elements of
    /// <paramref name="multiArray"/> in row-major order.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="multiArray"/> is <see langword="null"/>.
    /// </exception>
    public static T[] Flatten<T>(T[,] multiArray)
    {
        ArgumentNullException.ThrowIfNull(multiArray);

        int rows = multiArray.GetLength(0);
        int cols = multiArray.GetLength(1);
        T[] result = new T[rows * cols];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[index++] = multiArray[i, j];
            }
        }

        return result;
    }
}
