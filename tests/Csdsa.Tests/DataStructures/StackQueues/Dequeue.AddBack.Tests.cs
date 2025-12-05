using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class DequeTests
{
    [Fact]
    public void Deque_ShouldAddAndRemoveFromBothEnds()
    {
        Deque<string> deque = new Deque<string>();
        deque.AddBack("b");
        deque.AddFront("a");
        deque.AddBack("c");

        Assert.Equal("a", deque.PeekFront());
        Assert.Equal("c", deque.PeekBack());
        Assert.Equal("a", deque.RemoveFront());
        Assert.Equal("c", deque.RemoveBack());
        Assert.Equal("b", deque.RemoveFront());
        Assert.True(deque.IsEmpty);
    }
}
