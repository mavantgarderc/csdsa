using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class TwoStackQueueTests
{
    [Fact]
    public void TwoStackQueue_ShouldSimulateQueueBehavior()
    {
        TwoStackQueue<int> queue = new TwoStackQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);

        Assert.Equal(1, queue.Dequeue());
        Assert.Equal(2, queue.Peek());
    }
}
