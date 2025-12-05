namespace Csdsa.DataStructures.Arrays;

public partial class DynamicArray<T>
{
    /// <summary>
    /// Gets the total number of elements that the internal array can hold
    /// without resizing.
    /// </summary>
    public int Capacity
    {
        get { return _items.Length; }
    }
}
