using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class CircularQueueTests
{
    [Fact]
    public void CircularQueue_EmptyAndFullChecks()
    {
        CircularQueue<string> queue = new CircularQueue<string>(1);

        Assert.True(queue.IsEmpty);

        queue.Enqueue("item");

        Assert.True(queue.IsFull);
    }
}
