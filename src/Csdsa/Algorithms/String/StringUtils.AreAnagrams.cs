namespace Csdsa.Algorithms.Strings;

public static partial class StringUtils
{
    /// <summary>
    /// Determines whether two strings are anagrams of each other.
    /// The comparison is case-sensitive and includes all characters.
    /// </summary>
    /// <param name="first">The first string.</param>
    /// <param name="second">The second string.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="first"/> and <paramref name="second"/>
    /// are anagrams; otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="first"/> or <paramref name="second"/> is <see langword="null"/>.
    /// </exception>
    public static bool AreAnagrams(string first, string second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);

        if (first.Length != second.Length)
        {
            return false;
        }

        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach (char ch in first)
        {
            counts[ch] = counts.TryGetValue(ch, out int value) ? value + 1 : 1;
        }

        foreach (char ch in second)
        {
            if (!counts.TryGetValue(ch, out int value))
            {
                return false;
            }

            value--;
            counts[ch] = value;

            if (value < 0)
            {
                return false;
            }
        }

        return true;
    }
}
