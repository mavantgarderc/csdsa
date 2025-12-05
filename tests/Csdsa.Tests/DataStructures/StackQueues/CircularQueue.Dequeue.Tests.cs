using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class CircularQueueTests
{
    [Fact]
    public void CircularQueue_ShouldEnqueueAndDequeueInOrder()
    {
        CircularQueue<int> queue = new CircularQueue<int>(2);
        queue.Enqueue(1);
        queue.Enqueue(2);

        Assert.True(queue.IsFull);
        Assert.Equal(1, queue.Dequeue());
        Assert.Equal(2, queue.Peek());
    }

    [Fact]
    public void CircularQueue_Exceptions()
    {
        CircularQueue<int> queue = new CircularQueue<int>(1);

        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());

        queue.Enqueue(42);

        Assert.Throws<InvalidOperationException>(() => queue.Enqueue(99));
    }
}
