namespace Csdsa.DataStructures.Arrays;

public static partial class ArrayUtils
{
    /// <summary>
    /// Finds the maximum value in the specified integer array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <returns>The maximum value in the array.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="array"/> is <see langword="null"/> or has length zero.
    /// </exception>
    public static int FindMax(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }

        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }
}
