namespace Csdsa.Algorithms.Strings;

public static partial class StringUtils
{
    /// <summary>
    /// Finds the first non-repeating character in the specified string.
    /// </summary>
    /// <param name="input">The string to inspect.</param>
    /// <returns>
    /// The first character that appears exactly once in <paramref name="input"/>,
    /// or <see langword="null"/> if no such character exists or the string is empty.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="input"/> is <see langword="null"/>.
    /// </exception>
    public static char? FirstUniqueChar(string input)
    {
        ArgumentNullException.ThrowIfNull(input);

        if (input.Length == 0)
        {
            return null;
        }

        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char ch in input)
        {
            frequency[ch] = frequency.TryGetValue(ch, out int value) ? value + 1 : 1;
        }

        foreach (char ch in input)
        {
            if (frequency[ch] == 1)
            {
                return ch;
            }
        }

        return null;
    }
}
