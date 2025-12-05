using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class PriorityQueueWrapperTests
{
    [Fact]
    public void PriorityQueue_ShouldRespectPriorityOrder()
    {
        PriorityQueueWrapper<int, string> pq = new PriorityQueueWrapper<int, string>();
        pq.Enqueue("low", 2);
        pq.Enqueue("high", 1);

        Assert.False(pq.IsEmpty);
        Assert.Equal("high", pq.Peek());
        Assert.Equal("high", pq.Dequeue());
        Assert.Equal("low", pq.Dequeue());
        Assert.True(pq.IsEmpty);
    }
}
