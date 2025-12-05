using System.Diagnostics.CodeAnalysis;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Represents a fixed-capacity linear queue backed by an array.
/// </summary>
[SuppressMessage(
    "Usage",
    "CA1510:Use ArgumentNullException.ThrowIfNull",
    Justification = "Explicit null checks are preferred with nullable disabled.")]
public partial class LinearQueueUtils<T>
{
    private readonly T[] _items;
    private int _front;
    private int _rear;
    private int _count;
}
