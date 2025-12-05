namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the default constructor for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArrayList{T}"/> class
    /// with a default initial capacity.
    /// </summary>
    public ArrayList()
    {
        _items = new T[DefaultCapacity];
    }
}
