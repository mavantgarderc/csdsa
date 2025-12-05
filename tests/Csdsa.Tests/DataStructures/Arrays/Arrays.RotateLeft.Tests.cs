using Csdsa.DataStructures.Arrays;
using Xunit;
using static Csdsa.DataStructures.Arrays.Arrays;

namespace Csdsa.Tests.DataStructures.Arrays;

public class ArraysRotateLeftTests
{
    [Fact]
    public void RotateLeft_By2_ReturnsCorrectResult()
    {
        int[] input = [1, 2, 3, 4, 5];
        int[] expected = [3, 4, 5, 1, 2];

        RotateLeft(input, 2);

        Assert.Equal(expected, input);
    }

    [Fact]
    public void RotateLeft_By2_ReturnsExpectedSequence_34512()
    {
        int[] input = [1, 2, 3, 4, 5];
        int[] expected = [3, 4, 5, 1, 2];

        RotateLeft(input, 2);

        Assert.Equal(expected, input);
    }
}
