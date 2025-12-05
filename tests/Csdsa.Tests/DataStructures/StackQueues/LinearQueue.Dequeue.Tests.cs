using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class LinearQueueTests
{
    [Fact]
    public void LinearQueue_EmptyOperations_ShouldThrow()
    {
        LinearQueue<int> queue = new LinearQueue<int>();

        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        Assert.Throws<InvalidOperationException>(() => queue.Peek());
    }
}
