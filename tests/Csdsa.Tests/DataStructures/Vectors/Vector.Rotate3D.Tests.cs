using System;
using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorRotate3DTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 0, 0 }, new double[] { 0, 1, 0 }, Math.PI / 2, new double[] { 0, 0, -1 })]
    [InlineData(new double[] { 0, 1, 0 }, new double[] { 1, 0, 0 }, Math.PI, new double[] { 0, -1, 0 })]
    [InlineData(new double[] { 0, 0, 1 }, new double[] { 0, 1, 0 }, Math.PI, new double[] { 0, 0, -1 })]
    [InlineData(new double[] { 1, 0, 0 }, new double[] { 1, 1, 1 }, 2 * Math.PI / 3, new double[] { 0, 1, 0 })]
    public void Rotate3D_RotatesVector(double[] components, double[] axis, double angle, double[] expected)
    {
        Vector<double> vector = new Vector<double>(components);
        Vector<double> axisVector = new Vector<double>(axis).Normalize();
        Vector<double> expectedVector = new Vector<double>(expected);

        Vector<double> result = vector.Rotate3D(axisVector, angle);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expectedVector[i], result[i], Tolerance);
        }
    }
}
