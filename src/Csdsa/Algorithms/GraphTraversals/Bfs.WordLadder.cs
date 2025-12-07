namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Bfs
{
    /// <summary>
    /// Computes the length of the shortest transformation sequence from
    /// <paramref name="beginWord"/> to <paramref name="endWord"/>,
    /// changing one letter at a time and requiring each intermediate word
    /// to appear in <paramref name="wordList"/>.
    /// </summary>
    /// <param name="beginWord">The starting word.</param>
    /// <param name="endWord">The target word.</param>
    /// <param name="wordList">The dictionary of allowed intermediate words.</param>
    /// <returns>
    /// The number of words in the shortest transformation sequence,
    /// or 0 if no transformation is possible.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="beginWord"/>, <paramref name="endWord"/>,
    /// or <paramref name="wordList"/> is <see langword="null"/>.
    /// </exception>
    public static int WordLadder(
        string beginWord,
        string endWord,
        IReadOnlyList<string> wordList)
    {
        ArgumentNullException.ThrowIfNull(beginWord);
        ArgumentNullException.ThrowIfNull(endWord);
        ArgumentNullException.ThrowIfNull(wordList);

        HashSet<string> words = new HashSet<string>(wordList);

        if (!words.Contains(endWord))
        {
            return 0;
        }

        Queue<(string Word, int Depth)> queue = new Queue<(string, int)>();
        queue.Enqueue((beginWord, 1));

        while (queue.Count > 0)
        {
            (string word, int depth) = queue.Dequeue();

            if (word == endWord)
            {
                return depth;
            }

            for (int i = 0; i < word.Length; i++)
            {
                char[] chars = word.ToCharArray();

                for (char c = 'a'; c <= 'z'; c++)
                {
                    chars[i] = c;
                    string next = new string(chars);

                    if (!words.Contains(next))
                    {
                        continue;
                    }

                    words.Remove(next);
                    queue.Enqueue((next, depth + 1));
                }
            }
        }

        return 0;
    }
}
