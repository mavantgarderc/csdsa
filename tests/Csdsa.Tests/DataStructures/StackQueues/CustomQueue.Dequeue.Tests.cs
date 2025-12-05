using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class CustomQueueTests
{
    [Fact]
    public void Queue_EmptyOperations_ShouldThrow()
    {
        CustomQueue<char> queue = new CustomQueue<char>();

        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        Assert.Throws<InvalidOperationException>(() => queue.Peek());
    }
}
