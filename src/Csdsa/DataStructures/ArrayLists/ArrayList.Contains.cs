namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Determines whether the list contains a specific element.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="item"/> is found; otherwise,
    /// <see langword="false"/>.
    /// </returns>
    public bool Contains(T item)
    {
        return IndexOf(item) >= 0;
    }
}
