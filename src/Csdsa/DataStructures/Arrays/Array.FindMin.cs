using System;

namespace Csdsa.DataStructures.Arrays;

/// <summary>
/// Provides methods for finding extremum values in arrays.
/// </summary>
public static partial class ArrayUtils
{
    /// <summary>
    /// Finds the minimum value in the specified integer array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <returns>The minimum value in the array.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="array"/> is <see langword="null"/> or has length zero.
    /// </exception>
    public static int FindMin(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }

        int min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        return min;
    }
}
