using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class CustomStackTests
{
    [Fact]
    public void Stack_ShouldPushAndPopCorrectly()
    {
        CustomStack<int> stack = new CustomStack<int>();
        stack.Push(10);
        stack.Push(20);

        Assert.False(stack.IsEmpty);
        Assert.Equal(20, stack.Pop());
        Assert.Equal(10, stack.Pop());
        Assert.True(stack.IsEmpty);
    }
}
