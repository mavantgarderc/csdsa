namespace Csdsa.DataStructures.Arrays;

/// <summary>
/// Defines a contract for common array algorithms such as rotation, searching,
/// merging, reversal, and transformations between different array shapes.
/// </summary>
public interface IArray
{
    /// <summary>
    /// Rotates the elements of the specified array to the right by the given number of positions.
    /// </summary>
    /// <param name="array">The array whose elements should be rotated.</param>
    /// <param name="k">
    /// The number of positions to rotate the array to the right.
    /// The value is taken modulo the array length.
    /// </param>
    void RotateRight(int[] array, int k);

    /// <summary>
    /// Rotates the elements of the specified array to the left by the given number of positions.
    /// </summary>
    /// <param name="array">The array whose elements should be rotated.</param>
    /// <param name="k">
    /// The number of positions to rotate the array to the left.
    /// The value is taken modulo the array length.
    /// </param>
    void RotateLeft(int[] array, int k);

    /// <summary>
    /// Finds the maximum value in the specified integer array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <returns>The maximum value in the array.</returns>
    int FindMax(int[] array);

    /// <summary>
    /// Finds the minimum value in the specified integer array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <returns>The minimum value in the array.</returns>
    int FindMin(int[] array);

    /// <summary>
    /// Performs a linear search for the specified target value in the given array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <param name="target">The value to locate in the array.</param>
    /// <returns>
    /// The zero-based index of the first occurrence of <paramref name="target"/> in
    /// <paramref name="array"/>, or -1 if the value is not found or the array is null.
    /// </returns>
    int LinearSearch(int[] array, int target);

    /// <summary>
    /// Searches for a specified value in a sorted integer array using the binary search algorithm.
    /// </summary>
    /// <param name="array">The sorted array to search.</param>
    /// <param name="target">The value to locate in the array.</param>
    /// <returns>
    /// The zero-based index of <paramref name="target"/> in <paramref name="array"/>,
    /// or -1 if the value is not found or the array is null.
    /// </returns>
    int BinarySearch(int[] array, int target);

    /// <summary>
    /// Merges two non-null, non-empty sorted integer arrays into a single sorted array.
    /// </summary>
    /// <param name="first">The first sorted input array.</param>
    /// <param name="second">The second sorted input array.</param>
    /// <returns>A new sorted array containing all elements of both input arrays.</returns>
    int[] MergeSortedArrays(int[] first, int[] second);

    /// <summary>
    /// Reverses the elements of the specified array in place.
    /// </summary>
    /// <typeparam name="T">The element type of the array.</typeparam>
    /// <param name="array">The array whose elements should be reversed.</param>
    void Reverse<T>(T[] array);

    /// <summary>
    /// Flattens a two-dimensional rectangular array into a one-dimensional array.
    /// </summary>
    /// <typeparam name="T">The element type of the array.</typeparam>
    /// <param name="multiArray">The two-dimensional array to flatten.</param>
    /// <returns>
    /// A new one-dimensional array containing the elements of
    /// <paramref name="multiArray"/> in row-major order.
    /// </returns>
    T[] Flatten<T>(T[,] multiArray);

    /// <summary>
    /// Converts a jagged array to a rectangular two-dimensional array.
    /// </summary>
    /// <typeparam name="T">The element type of the array.</typeparam>
    /// <param name="jaggedArray">The jagged array to convert.</param>
    /// <returns>
    /// A new two-dimensional array containing the same elements as
    /// <paramref name="jaggedArray"/>.
    /// </returns>
    T[,] ToRectangular<T>(T[][] jaggedArray);
}
