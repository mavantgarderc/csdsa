namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Push(T)"/> operation for <see cref="CustomStackUtils{T}"/>.
/// </summary>
public partial class CustomStackUtils<T>
{
    /// <summary>
    /// Pushes an element onto the top of the stack.
    /// </summary>
    /// <param name="item">The element to push.</param>
    public void Push(T item)
    {
        _list.Add(item);
    }
}
