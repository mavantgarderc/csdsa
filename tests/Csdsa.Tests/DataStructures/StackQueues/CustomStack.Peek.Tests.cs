using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class CustomStackTests
{
    [Fact]
    public void Stack_Peek_ShouldReturnTopWithoutRemoving()
    {
        CustomStack<string> stack = new CustomStack<string>();
        stack.Push("x");

        Assert.Equal("x", stack.Peek());
        Assert.False(stack.IsEmpty);
    }
}
