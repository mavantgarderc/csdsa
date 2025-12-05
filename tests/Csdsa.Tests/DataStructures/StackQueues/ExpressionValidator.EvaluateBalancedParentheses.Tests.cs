using Csdsa.DataStructures.StackQueues;
using Xunit;

namespace Csdsa.Tests.DataStructures.StackQueues;

public class ExpressionValidatorTests
{
    [Theory]
    [InlineData("()[]{}", true)]
    [InlineData("({[]})", true)]
    [InlineData("([)]", false)]
    [InlineData("({[})]", false)]
    [InlineData("", true)]
    public void EvaluateBalancedParentheses_ShouldValidateCorrectly(string expression, bool expected)
    {
        Assert.Equal(expected, ExpressionValidator.EvaluateBalancedParentheses(expression));
    }
}
