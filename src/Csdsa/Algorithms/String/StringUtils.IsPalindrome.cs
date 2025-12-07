namespace Csdsa.Algorithms.Strings;

public static partial class StringUtils
{
    /// <summary>
    /// Determines whether the specified string is a palindrome, ignoring
    /// case and non-alphanumeric characters.
    /// </summary>
    /// <param name="input">The string to inspect.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="input"/> is a palindrome
    /// under the given normalization; otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="input"/> is <see langword="null"/>.
    /// </exception>
    public static bool IsPalindrome(string input)
    {
        ArgumentNullException.ThrowIfNull(input);

        if (input.Length == 0)
        {
            return true;
        }

        string normalized = new string(
            input
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLowerInvariant)
                .ToArray());

        int mid = normalized.Length / 2;

        for (int i = 0; i < mid; i++)
        {
            if (normalized[i] != normalized[normalized.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
