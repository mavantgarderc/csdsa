using System;
using Csdsa.DataStructures.Arrays;
using Xunit;
using static Csdsa.DataStructures.Arrays.Arrays;

namespace Csdsa.Tests.DataStructures.Arrays;

public class ArraysFindMaxTests
{
    [Fact]
    public void FindMax_ReturnsCorrectValue()
    {
        int[] input = [4, 7, 2, 9, 5];

        int max = FindMax(input);

        Assert.Equal(9, max);
    }

    [Fact]
    public void FindMax_EmptyArray_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => FindMax([]));
    }

    [Fact]
    public void FindMax_WithAnotherArray_ReturnsExpectedMax()
    {
        int[] input = [1, 9, 3, 7];

        int max = FindMax(input);

        Assert.Equal(9, max);
    }
}
