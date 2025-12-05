using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class CustomQueueTests
{
    [Fact]
    public void Queue_ShouldEnqueueAndDequeueCorrectly()
    {
        CustomQueue<int> queue = new CustomQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);

        Assert.False(queue.IsEmpty);
        Assert.Equal(1, queue.Dequeue());
        Assert.Equal(2, queue.Dequeue());
        Assert.True(queue.IsEmpty);
    }
}
