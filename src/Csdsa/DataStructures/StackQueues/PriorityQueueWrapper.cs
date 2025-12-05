using System.Collections.Generic;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Wraps the <see cref="PriorityQueue{TElement,TPriority}"/> type with a simpler API.
/// </summary>
public partial class PriorityQueueWrapper<TPriority, TValue>
{
    private readonly PriorityQueue<TValue, TPriority> _priorityQueue = new PriorityQueue<TValue, TPriority>();
}
