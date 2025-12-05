using System;
using Csdsa.DataStructures.Arrays;
using Xunit;
using static Csdsa.DataStructures.Arrays.Arrays;

namespace Csdsa.Tests.DataStructures.Arrays;

public class ArraysRotateRightTests
{
    [Fact]
    public void RotateRight_By3_ReturnsCorrectResult()
    {
        int[] input = [1, 2, 3, 4, 5];
        int[] expected = [3, 4, 5, 1, 2];

        RotateRight(input, 3);

        Assert.Equal(expected, input);
    }

    [Fact]
    public void RotateRight_NullInput_DoesNotThrow()
    {
        int[] input = [];

        Exception exception = Record.Exception(() => RotateRight(input, 2));

        Assert.Null(exception);
    }

    [Fact]
    public void RotateRight_By2_ReturnsExpectedSequence_45123()
    {
        int[] input = [1, 2, 3, 4, 5];
        int[] expected = [4, 5, 1, 2, 3];

        RotateRight(input, 2);

        Assert.Equal(expected, input);
    }
}
