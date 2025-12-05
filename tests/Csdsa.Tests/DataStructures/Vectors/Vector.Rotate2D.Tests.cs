using System;
using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorRotate2DTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 0 }, Math.PI / 2, new double[] { 0, 1 })]
    [InlineData(new double[] { 0, 1 }, Math.PI, new double[] { 0, -1 })]
    [InlineData(new double[] { 1, 0 }, 0, new double[] { 1, 0 })]
    public void Rotate2D_RotatesVector(double[] components, double angle, double[] expected)
    {
        Vector<double> vector = new Vector<double>(components);
        Vector<double> expectedVector = new Vector<double>(expected);

        Vector<double> result = vector.Rotate2D(angle);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expectedVector[i], result[i], Tolerance);
        }
    }
}
