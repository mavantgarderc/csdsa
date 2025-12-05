namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="IsEmpty"/> property for <see cref="CustomStackUtils{T}"/>.
/// </summary>
public partial class CustomStackUtils<T>
{
    /// <summary>
    /// Gets a value indicating whether the stack is empty.
    /// </summary>
    public bool IsEmpty => _list.Count == 0;
}
