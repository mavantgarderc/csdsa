namespace Csdsa.DataStructures.Arrays;

/// <summary>
/// Provides methods for reversing arrays.
/// </summary>
public static partial class ArrayUtils
{
    /// <summary>
    /// Reverses the elements of the specified array in place.
    /// </summary>
    /// <typeparam name="T">The element type of the array.</typeparam>
    /// <param name="array">The array whose elements should be reversed.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="array"/> is <see langword="null"/>.
    /// </exception>
    public static void Reverse<T>(T[] array)
    {
        ArgumentNullException.ThrowIfNull(array);

        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            (array[left], array[right]) = (array[right], array[left]);
            left++;
            right--;
        }
    }
}
