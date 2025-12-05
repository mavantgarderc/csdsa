namespace Csdsa.DataStructures.Arrays;

public static partial class ArrayUtils
{
    /// <summary>
    /// Performs a linear search for the specified target value in the given array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <param name="target">The value to locate in the array.</param>
    /// <returns>
    /// The zero-based index of the first occurrence of <paramref name="target"/> in
    /// <paramref name="array"/>, or -1 if the value is not found or the array is null.
    /// </returns>
    public static int LinearSearch(int[] array, int target)
    {
        if (array == null)
        {
            return -1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }

        return -1;
    }
}
