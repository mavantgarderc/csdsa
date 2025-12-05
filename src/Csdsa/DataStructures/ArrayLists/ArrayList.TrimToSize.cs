namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Sets the capacity to the actual number of elements in the list,
    /// if that number is less than the current capacity.
    /// </summary>
    public void TrimToSize()
    {
        Capacity = _size;
    }
}
