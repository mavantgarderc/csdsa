using System.Text;

namespace Csdsa.Algorithms.Strings;

public static partial class StringUtils
{
    /// <summary>
    /// Reverses the specified string.
    /// </summary>
    /// <param name="input">The string to reverse.</param>
    /// <returns>A new string whose characters are in reverse order.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="input"/> is <see langword="null"/>.
    /// </exception>
    public static string Reverse(string input)
    {
        ArgumentNullException.ThrowIfNull(input);

        StringBuilder builder = new StringBuilder(input.Length);

        for (int i = input.Length - 1; i >= 0; i--)
        {
            builder.Append(input[i]);
        }

        return builder.ToString();
    }
}
