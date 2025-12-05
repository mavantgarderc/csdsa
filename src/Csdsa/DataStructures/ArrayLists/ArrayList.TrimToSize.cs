namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="TrimToSize"/> method for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
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
