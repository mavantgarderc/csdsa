using System.Diagnostics.CodeAnalysis;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Represents a fixed-capacity circular queue backed by an array.
/// </summary>
[SuppressMessage(
    "Usage",
    "CA1510:Use ArgumentNullException.ThrowIfNull",
    Justification = "Explicit null checks are preferred with nullable disabled.")]
public partial class CircularQueueUtils<T>
{
    private readonly T[] _buffer;
    private int _head;
    private int _tail;
    private int _size;
}
