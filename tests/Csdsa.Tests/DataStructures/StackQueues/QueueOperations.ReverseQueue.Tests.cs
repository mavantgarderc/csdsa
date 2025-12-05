using System.Collections.Generic;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public class QueueOperationsTests
{
    [Fact]
    public void ReverseQueue_ShouldReverseItems()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Queue<int> reversed = QueueOperations.ReverseQueue(queue);

        Assert.Equal(3, reversed.Dequeue());
        Assert.Equal(2, reversed.Dequeue());
        Assert.Equal(1, reversed.Dequeue());
    }
}
