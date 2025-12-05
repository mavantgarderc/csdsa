using System.Diagnostics.CodeAnalysis;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides a collection of stack- and queue-based data structures and utilities.
///
/// Concepts:
/// <list type="bullet">
/// <item>Generic data structures.</item>
/// <item>Stack and queue implementations.</item>
/// <item>Encapsulation with private backing fields.</item>
/// <item>Indexing and syntactic sugar in C#.</item>
/// <item>Circular queue design.</item>
/// <item>Two-stack queue simulation.</item>
/// <item>Stack-based expression evaluation.</item>
/// <item>Queue reversal using a stack.</item>
/// <item>Double-ended queue (<see cref="Dequeue{T}"/>) pattern.</item>
/// <item>Priority-based queueing with <see cref="PriorityQueueWrapper{TPriority, TValue}"/>.</item>
/// </list>
///
/// Key practices:
/// <list type="bullet">
/// <item>Exception handling for empty-state access.</item>
/// <item>Use of <see cref="System.Collections.Generic.List{T}"/> as an internal buffer.</item>
/// <item>Expression-bodied members for brevity where appropriate.</item>
/// <item>Readonly field enforcement for immutability.</item>
/// <item>Separation of concerns for modularity.</item>
/// <item>Defensive programming with validation.</item>
/// <item>O(1) amortized design where applicable.</item>
/// <item>Minimizing allocations in queue operations.</item>
/// <item>Encapsulating .NET built-ins for predictability.</item>
/// <item>Guarding edge-case usage through contract validation.</item>
/// </list>
/// </summary>
[SuppressMessage(
    "Usage",
    "CA1510:Use ArgumentNullException.ThrowIfNull",
    Justification = "Explicit null checks are preferred with nullable disabled.")]
public static partial class StackQueueUtils
{
}
