using Csdsa.DataStructures.Arrays;
using Xunit;
using static Csdsa.DataStructures.Arrays.Arrays;

namespace Csdsa.Tests.DataStructures.Arrays;

public class ArraysFlattenTests
{
    [Fact]
    public void Flatten_Generic_FlattensRectangularArray()
    {
        int[,] multi = new int[,] { { 1, 2 }, { 3, 4 } };
        int[] expected = [1, 2, 3, 4];

        int[] result = Flatten(multi);

        Assert.Equal(expected, result);
    }
}
