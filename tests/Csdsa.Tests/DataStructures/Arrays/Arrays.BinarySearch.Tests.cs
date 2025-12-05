using Csdsa.DataStructures.Arrays;
using Xunit;
using static Csdsa.DataStructures.Arrays.Arrays;

namespace Csdsa.Tests.DataStructures.Arrays;

public class ArraysBinarySearchTests
{
    [Fact]
    public void BinarySearch_FindsElement()
    {
        int[] input = [1, 3, 5, 7, 9];

        int index = BinarySearch(input, 7);

        Assert.Equal(3, index);
    }

    [Fact]
    public void BinarySearch_ElementNotFound_ReturnsMinus1()
    {
        int[] input = [1, 2, 4, 6];

        int index = BinarySearch(input, 3);

        Assert.Equal(-1, index);
    }

    [Fact]
    public void BinarySearch_EmptyInput_ReturnsMinus1()
    {
        int[] input = [];

        int index = BinarySearch(input, 5);

        Assert.Equal(-1, index);
    }

    [Fact]
    public void BinarySearch_FindsAndDoesNotFindElements_AsExpected()
    {
        int[] input = [10, 20, 30, 40];

        Assert.Equal(2, BinarySearch(input, 30));
        Assert.Equal(-1, BinarySearch(input, 5));
    }
}
