using System;

namespace Csdsa.DataStructures.Arrays;

/// <summary>
/// Provides methods for merging sorted arrays.
/// </summary>
public static partial class ArrayUtils
{
    /// <summary>
    /// Merges two non-null, non-empty sorted integer arrays into a single sorted array.
    /// </summary>
    /// <param name="first">The first sorted input array.</param>
    /// <param name="second">The second sorted input array.</param>
    /// <returns>A new sorted array containing all elements of both input arrays.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown when either <paramref name="first"/> or <paramref name="second"/> is
    /// <see langword="null"/> or has length zero.
    /// </exception>
    public static int[] MergeSortedArrays(int[] first, int[] second)
    {
        if (first == null || first.Length == 0 || second == null || second.Length == 0)
        {
            throw new ArgumentException("input cannot be null.");
        }

        int i = 0;
        int j = 0;
        int k = 0;
        int[] result = new int[first.Length + second.Length];

        while (i < first.Length && j < second.Length)
        {
            if (first[i] <= second[j])
            {
                result[k++] = first[i++];
            }
            else
            {
                result[k++] = second[j++];
            }
        }

        while (i < first.Length)
        {
            result[k++] = first[i++];
        }

        while (j < second.Length)
        {
            result[k++] = second[j++];
        }

        return result;
    }
}
