namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Gets a value indicating whether the collection is read-only.
    /// </summary>
    /// <remarks>
    /// This implementation always returns <see langword="false"/>.
    /// </remarks>
    public bool IsReadOnly
    {
        get { return false; }
    }
}
