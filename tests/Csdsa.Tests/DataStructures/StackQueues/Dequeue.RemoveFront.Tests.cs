using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class DequeTests
{
    [Fact]
    public void Deque_EmptyOperations_ShouldThrow()
    {
        Deque<int> deque = new Deque<int>();

        Assert.Throws<InvalidOperationException>(() => deque.PeekFront());
        Assert.Throws<InvalidOperationException>(() => deque.PeekBack());
        Assert.Throws<InvalidOperationException>(() => deque.RemoveFront());
        Assert.Throws<InvalidOperationException>(() => deque.RemoveBack());
    }
}
