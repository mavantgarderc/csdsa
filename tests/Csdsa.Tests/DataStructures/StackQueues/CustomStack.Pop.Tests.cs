using System;
using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public partial class CustomStackTests
{
    [Fact]
    public void Stack_EmptyOperations_ShouldThrow()
    {
        CustomStack<double> stack = new CustomStack<double>();

        Assert.Throws<InvalidOperationException>(() => stack.Pop());
        Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }
}
