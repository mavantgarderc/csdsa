namespace Csdsa.DataStructures.Arrays;

public static partial class ArrayUtils
{
    /// <summary>
    /// Searches for a specified value in a sorted integer array using the binary search algorithm.
    /// </summary>
    /// <param name="array">The sorted array to search.</param>
    /// <param name="target">The value to locate in the array.</param>
    /// <returns>
    /// The zero-based index of <paramref name="target"/> in <paramref name="array"/>,
    /// or -1 if the value is not found or the array is null.
    /// </returns>
    /// <remarks>
    /// The input array must be sorted in ascending order for the result to be meaningful.
    /// </remarks>
    public static int BinarySearch(int[] array, int target)
    {
        if (array == null)
        {
            return -1;
        }

        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + ((right - left) / 2);
            if (array[mid] == target)
            {
                return mid;
            }

            if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}
