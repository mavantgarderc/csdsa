using System.Diagnostics.CodeAnalysis;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Represents a double-ended queue (deque) backed by <see cref="LinkedList{T}"/>.
/// </summary>
[SuppressMessage(
    "Usage",
    "CA1510:Use ArgumentNullException.ThrowIfNull",
    Justification = "Explicit null checks are preferred with nullable disabled.")]
public partial class Dequeue<T>
{
    private readonly LinkedList<T> _list = new LinkedList<T>();
}
