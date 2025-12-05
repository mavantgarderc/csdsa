using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class CircularQueueTests
{
    [Fact]
    public void CircularQueue_InvalidCapacity_ShouldThrow()
    {
        Assert.Throws<ArgumentException>(() => new CircularQueue<int>(0));
    }
}
