namespace Csdsa.Algorithms.Strings;

public static partial class StringUtils
{
    /// <summary>
    /// Finds all occurrences of <paramref name="pattern"/> in <paramref name="text"/>
    /// using the Knuth–Morris–Pratt (KMP) algorithm.
    /// </summary>
    /// <param name="pattern">The pattern to search for.</param>
    /// <param name="text">The text to search within.</param>
    /// <returns>
    /// A read-only list of zero-based indices where <paramref name="pattern"/> occurs in
    /// <paramref name="text"/>. Returns an empty list if <paramref name="pattern"/> or
    /// <paramref name="text"/> is empty.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="pattern"/> or <paramref name="text"/> is <see langword="null"/>.
    /// </exception>
    public static IReadOnlyList<int> KmpSearch(string pattern, string text)
    {
        ArgumentNullException.ThrowIfNull(pattern);
        ArgumentNullException.ThrowIfNull(text);

        if (pattern.Length == 0 || text.Length == 0)
        {
            return Array.Empty<int>();
        }

        int m = pattern.Length;
        int n = text.Length;
        List<int> result = new List<int>();

        int[] lps = ComputeLpsArray(pattern);
        int i = 0; // index for text
        int j = 0; // index for pattern

        while (i < n)
        {
            if (pattern[j] == text[i])
            {
                j++;
                i++;
            }

            if (j == m)
            {
                result.Add(i - j);
                j = lps[j - 1];
            }
            else if (i < n && pattern[j] != text[i])
            {
                if (j != 0)
                {
                    j = lps[j - 1];
                }
                else
                {
                    i++;
                }
            }
        }

        return result;
    }

    private static int[] ComputeLpsArray(string pattern)
    {
        int m = pattern.Length;
        int[] lps = new int[m];

        int length = 0;
        int i = 1;

        lps[0] = 0;

        while (i < m)
        {
            if (pattern[i] == pattern[length])
            {
                length++;
                lps[i] = length;
                i++;
            }
            else
            {
                if (length != 0)
                {
                    length = lps[length - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }

        return lps;
    }
}
