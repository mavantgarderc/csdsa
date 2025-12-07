using Csdsa.Algorithms.Tuples;

using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void RotateLeft_ShiftsElementsLeft()
    {
        (int First, int Second, int Third) input = (1, 2, 3);

        (int Second, int Third, int First) result = TupleUtils.RotateLeft(input);

        Assert.Equal((2, 3, 1), (result.Second, result.Third, result.First));
    }

    [Fact]
    public void RotateRight_ShiftsElementsRight()
    {
        (int First, int Second, int Third) input = (1, 2, 3);

        (int Third, int First, int Second) result = TupleUtils.RotateRight(input);

        Assert.Equal((3, 1, 2), (result.Third, result.First, result.Second));
    }
}
