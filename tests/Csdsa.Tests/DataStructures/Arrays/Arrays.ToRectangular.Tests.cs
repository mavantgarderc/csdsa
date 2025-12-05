using Csdsa.DataStructures.Arrays;
using Xunit;
using static Csdsa.DataStructures.Arrays.Arrays;

namespace Csdsa.Tests.DataStructures.Arrays;

public class ArraysToRectangularTests
{
    [Fact]
    public void ToRectangular_Generic_ConvertsJaggedToRectangular()
    {
        int[][] jagged =
        [
            [1, 2],
            [3, 4]
        ];

        int[,] result = ToRectangular(jagged);

        Assert.Equal(1, result[0, 0]);
        Assert.Equal(2, result[0, 1]);
        Assert.Equal(3, result[1, 0]);
        Assert.Equal(4, result[1, 1]);
    }
}
