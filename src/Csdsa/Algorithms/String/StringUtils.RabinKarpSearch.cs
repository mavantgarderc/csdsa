namespace Csdsa.Algorithms.Strings;

public static partial class StringUtils
{
    /// <summary>
    /// Finds all occurrences of <paramref name="pattern"/> in <paramref name="text"/>
    /// using the Rabin–Karp rolling-hash algorithm.
    /// </summary>
    /// <param name="text">The text to search.</param>
    /// <param name="pattern">The pattern to find.</param>
    /// <param name="prime">
    /// A prime modulus used in the rolling hash computation. Defaults to 101.
    /// </param>
    /// <returns>
    /// A read-only list of zero-based indices where <paramref name="pattern"/> occurs in
    /// <paramref name="text"/>. Returns an empty list if <paramref name="pattern"/> or
    /// <paramref name="text"/> is empty.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="text"/> or <paramref name="pattern"/> is <see langword="null"/>.
    /// </exception>
    public static IReadOnlyList<int> RabinKarpSearch(
        string text,
        string pattern,
        int prime = 101)
    {
        ArgumentNullException.ThrowIfNull(text);
        ArgumentNullException.ThrowIfNull(pattern);

        List<int> result = new List<int>();

        if (text.Length == 0 || pattern.Length == 0)
        {
            return result;
        }

        int m = pattern.Length;
        int n = text.Length;

        if (m > n)
        {
            return result;
        }

        long patternHash = 0;
        long textHash = 0;
        long h = 1;
        int d = 256;

        for (int i = 0; i < m - 1; i++)
        {
            h = (h * d) % prime;
        }

        for (int i = 0; i < m; i++)
        {
            patternHash = ((d * patternHash) + pattern[i]) % prime;
            textHash = ((d * textHash) + text[i]) % prime;
        }

        for (int i = 0; i <= n - m; i++)
        {
            if (patternHash == textHash)
            {
                bool match = true;

                for (int j = 0; j < m; j++)
                {
                    if (text[i + j] != pattern[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    result.Add(i);
                }
            }

            if (i < n - m)
            {
                long removed = text[i] * h;
                long temp = textHash - removed;
                long shifted = d * temp;
                long added = shifted + text[i + m];
                textHash = added % prime;

                if (textHash < 0)
                {
                    textHash += prime;
                }
            }
        }

        return result;
    }
}
