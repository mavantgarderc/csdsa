namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="IsReadOnly"/> property for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
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
