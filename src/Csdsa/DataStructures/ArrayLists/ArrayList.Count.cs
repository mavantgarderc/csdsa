namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="Count"/> property for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Gets the number of elements contained in the list.
    /// </summary>
    public int Count
    {
        get { return _size; }
    }
}
