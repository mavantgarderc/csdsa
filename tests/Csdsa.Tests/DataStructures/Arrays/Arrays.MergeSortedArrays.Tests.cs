using System;
using Csdsa.DataStructures.Arrays;
using Xunit;
using static Csdsa.DataStructures.Arrays.Arrays;

namespace Csdsa.Tests.DataStructures.Arrays;

public class ArraysMergeSortedArraysTests
{
    [Fact]
    public void MergeSortedArrays_ReturnsMergedSortedArray()
    {
        int[] a = [1, 3, 5];
        int[] b = [2, 4, 6];
        int[] expected = [1, 2, 3, 4, 5, 6];

        int[] result = MergeSortedArrays(a, b);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void MergeSortedArrays_EmptyInput_ThrowsException()
    {
        int[] a = [];
        int[] b = [1, 2, 3];

        Assert.Throws<ArgumentException>(() => MergeSortedArrays(a, b));
    }

    [Fact]
    public void MergeSortedArrays_ReturnsExpectedMergedSequence()
    {
        int[] a = [1, 3, 5];
        int[] b = [2, 4, 6];
        int[] expected = [1, 2, 3, 4, 5, 6];

        int[] result = MergeSortedArrays(a, b);

        Assert.Equal(expected, result);
    }
}
