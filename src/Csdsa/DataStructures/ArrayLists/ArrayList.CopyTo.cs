namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Copies the entire list to a compatible one-dimensional array, starting
    /// at the specified index of the target array.
    /// </summary>
    /// <param name="array">The destination array.</param>
    /// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
    public void CopyTo(T[] array, int arrayIndex)
    {
        Array.Copy(_items, 0, array, arrayIndex, _size);
    }
}
