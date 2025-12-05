namespace Csdsa.DataStructures.Arrays;

/// <summary>
/// Provides public helper methods for array manipulations.
/// </summary>
public static partial class ArrayUtils
{
    /// <summary>
    /// Reverses a contiguous range of elements within the specified array in place.
    /// </summary>
    /// <typeparam name="T">The element type of the array.</typeparam>
    /// <param name="array">The array that contains the range to reverse.</param>
    /// <param name="startIndex">The index of the first element in the range to reverse (inclusive).</param>
    /// <param name="endIndex">The index of the last element in the range to reverse (inclusive).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="array"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="startIndex"/> or <paramref name="endIndex"/> is out of range.
    /// </exception>
    /// <remarks>
    /// This method validates that <paramref name="startIndex"/> and <paramref name="endIndex"/>
    /// are valid indices into <paramref name="array"/>.
    /// </remarks>
    public static void ReverseRange<T>(T[] array, int startIndex, int endIndex)
    {
        ArgumentNullException.ThrowIfNull(array);

        if (startIndex < 0 || startIndex >= array.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < 0 || endIndex >= array.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }

        while (startIndex < endIndex)
        {
            (array[startIndex], array[endIndex]) = (array[endIndex], array[startIndex]);
            startIndex++;
            endIndex--;
        }
    }
}
