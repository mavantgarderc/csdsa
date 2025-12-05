using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class PriorityQueueWrapperTests
{
    [Fact]
    public void PriorityQueue_EmptyOperations_ShouldThrow()
    {
        PriorityQueueWrapper<int, string> pq = new PriorityQueueWrapper<int, string>();

        Assert.Throws<InvalidOperationException>(() => pq.Dequeue());
        Assert.Throws<InvalidOperationException>(() => pq.Peek());
    }
}
