namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides expression validation utilities for <see cref="ExpressionValidator"/>.
/// </summary>
public static partial class ExpressionValidator
{
    /// <summary>
    /// Evaluates whether the specified expression contains balanced parentheses, brackets, and braces.
    /// </summary>
    /// <param name="expression">
    /// The expression to evaluate. If the value is <c>null</c>, the method returns <c>false</c>.
    /// An empty string is considered balanced and returns <c>true</c>.
    /// </param>
    /// <returns>
    /// <c>true</c> if all parentheses, square brackets, and curly braces in the expression are
    /// properly balanced; otherwise, <c>false</c>.
    /// </returns>
    public static bool EvaluateBalancedParentheses(string expression)
    {
        if (expression == null)
        {
            return false;
        }

        if (expression.Length == 0)
        {
            return true;
        }

        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' },
        };

        foreach (char ch in expression)
        {
            if (bracketPairs.ContainsValue(ch))
            {
                stack.Push(ch);
            }
            else if (bracketPairs.ContainsKey(ch))
            {
                if (stack.Count == 0 || stack.Pop() != bracketPairs[ch])
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
