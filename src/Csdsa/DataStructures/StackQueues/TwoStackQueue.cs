using System.Diagnostics.CodeAnalysis;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Represents a queue implementation built from two internal stacks.
/// </summary>
[SuppressMessage(
    "Usage",
    "CA1510:Use ArgumentNullException.ThrowIfNull",
    Justification = "Explicit null checks are preferred with nullable disabled.")]
public partial class TwoStackQueueUtils<T>
{
    private readonly Stack<T> _input = new Stack<T>();
    private readonly Stack<T> _output = new Stack<T>();
}
