using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class CustomQueueTests
{
    [Fact]
    public void Queue_Peek_ShouldReturnFrontWithoutRemoving()
    {
        CustomQueue<string> queue = new CustomQueue<string>();
        queue.Enqueue("first");

        Assert.Equal("first", queue.Peek());
    }
}
