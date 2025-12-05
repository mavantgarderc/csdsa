namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArrayListUtils{T}"/> class
    /// with a default initial capacity.
    /// </summary>
    public ArrayListUtils()
    {
        _items = new T[DefaultCapacity];
    }
}
