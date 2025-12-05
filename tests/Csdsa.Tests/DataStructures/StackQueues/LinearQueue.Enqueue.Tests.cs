using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class LinearQueueTests
{
    [Fact]
    public void LinearQueue_ShouldEnqueueAndDequeueCorrectly()
    {
        LinearQueue<int> queue = new LinearQueue<int>(3);
        queue.Enqueue(1);
        queue.Enqueue(2);

        Assert.Equal(1, queue.Dequeue());
        Assert.Equal(2, queue.Peek());
    }

    [Fact]
    public void LinearQueue_ExceedingCapacity_ShouldThrow()
    {
        LinearQueue<int> queue = new LinearQueue<int>(1);
        queue.Enqueue(1);

        Assert.Throws<InvalidOperationException>(() => queue.Enqueue(2));
    }
}
