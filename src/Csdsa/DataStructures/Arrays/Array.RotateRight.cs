namespace Csdsa.DataStructures.Arrays;

public static partial class ArrayUtils
{
    /// <summary>
    /// Rotates the elements of the specified array to the right by the given number of positions.
    /// </summary>
    /// <param name="array">The array whose elements should be rotated.</param>
    /// <param name="k">
    /// The number of positions to rotate the array to the right.
    /// The value is taken modulo the array length.
    /// </param>
    /// <remarks>
    /// If <paramref name="array"/> is <see langword="null"/> or has length zero,
    /// the method returns without modifying the array.
    /// </remarks>
    public static void RotateRight(int[] array, int k)
    {
        if (array == null || array.Length == 0)
        {
            return;
        }

        int length = array.Length;
        k %= length;

        ReverseRange(array, 0, length - 1);
        ReverseRange(array, 0, k - 1);
        ReverseRange(array, k, length - 1);
    }
}
