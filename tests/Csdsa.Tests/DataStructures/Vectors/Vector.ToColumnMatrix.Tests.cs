using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorToColumnMatrixTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 2 })]
    [InlineData(new double[] { 3 })]
    [InlineData(new double[] { 4, 5, 6 })]
    [InlineData(new double[] { 0, 0, 0 })]
    public void ToColumnMatrix_CreatesMatrix(double[] components)
    {
        Vector<double> vector = new Vector<double>(components);

        double[,] matrix = vector.ToColumnMatrix();

        Assert.Equal(components.Length, matrix.GetLength(0));
        Assert.Equal(1, matrix.GetLength(1));

        for (int i = 0; i < components.Length; i++)
        {
            Assert.Equal(components[i], matrix[i, 0], Tolerance);
        }
    }
}
