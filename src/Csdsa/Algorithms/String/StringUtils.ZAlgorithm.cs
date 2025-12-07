namespace Csdsa.Algorithms.Strings;

public static partial class StringUtils
{
    /// <summary>
    /// Finds all occurrences of <paramref name="pattern"/> in <paramref name="text"/>
    /// using the Z-Algorithm in linear time.
    /// </summary>
    /// <param name="text">The text to search.</param>
    /// <param name="pattern">The pattern to find.</param>
    /// <returns>
    /// A read-only list of zero-based indices where <paramref name="pattern"/> occurs in
    /// <paramref name="text"/>. Returns an empty list if <paramref name="pattern"/> or
    /// <paramref name="text"/> is empty.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="text"/> or <paramref name="pattern"/> is <see langword="null"/>.
    /// </exception>
    public static IReadOnlyList<int> ZAlgorithm(string text, string pattern)
    {
        ArgumentNullException.ThrowIfNull(text);
        ArgumentNullException.ThrowIfNull(pattern);

        if (text.Length == 0 || pattern.Length == 0)
        {
            return Array.Empty<int>();
        }

        string combined = pattern + "$" + text;
        int n = combined.Length;
        int[] z = new int[n];

        int left = 0;
        int right = 0;

        for (int i = 1; i < n; i++)
        {
            if (i <= right)
            {
                z[i] = Math.Min(right - i + 1, z[i - left]);
            }

            while (i + z[i] < n && combined[z[i]] == combined[i + z[i]])
            {
                z[i]++;
            }

            if (i + z[i] - 1 > right)
            {
                left = i;
                right = i + z[i] - 1;
            }
        }

        List<int> result = new List<int>();

        for (int i = pattern.Length + 1; i < n; i++)
        {
            if (z[i] == pattern.Length)
            {
                result.Add(i - pattern.Length - 1);
            }
        }

        return result;
    }
}
