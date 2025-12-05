using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class TwoStackQueueTests
{
    [Fact]
    public void TwoStackQueue_EmptyOperations_ShouldThrow()
    {
        TwoStackQueue<string> queue = new TwoStackQueue<string>();

        Assert.True(queue.IsEmpty);
        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        Assert.Throws<InvalidOperationException>(() => queue.Peek());
    }
}
