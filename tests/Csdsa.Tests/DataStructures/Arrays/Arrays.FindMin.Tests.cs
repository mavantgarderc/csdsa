using Csdsa.DataStructures.Arrays;
using Xunit;
using static Csdsa.DataStructures.Arrays.Arrays;

namespace Csdsa.Tests.DataStructures.Arrays;

public class ArraysFindMinTests
{
    [Fact]
    public void FindMin_ReturnsCorrectValue()
    {
        int[] input = [4, 7, 2, 9, 5];

        int min = FindMin(input);

        Assert.Equal(2, min);
    }

    [Fact]
    public void FindMin_WithAnotherArray_ReturnsExpectedMin()
    {
        int[] input = [2, 3, 0, 5];

        int min = FindMin(input);

        Assert.Equal(0, min);
    }
}
