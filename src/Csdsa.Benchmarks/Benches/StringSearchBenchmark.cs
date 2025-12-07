using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using Csdsa.Algorithms.Strings;

namespace Csdsa.Benchmarks;

[MemoryDiagnoser]
public class StringSearchBenchmarks
{
    [Params(100, 1000)]
    public int TextRepeats { get; set; }

    private string _text = string.Empty;
    private string _pattern = string.Empty;

    [GlobalSetup]
    public void Setup()
    {
        // Base text and pattern from your tests.
        string baseText = "ABABDABACDABABCABAB";
        string basePattern = "ABABCABAB";

        // Repeat the base text to control size.
        System.Text.StringBuilder builder = new System.Text.StringBuilder();

        for (int i = 0; i < TextRepeats; i++)
        {
            builder.Append(baseText);
        }

        _text = builder.ToString();
        _pattern = basePattern;
    }

    [Benchmark(Description = "KMP search")]
    public IReadOnlyList<int> KmpSearch()
    {
        return StringUtils.KmpSearch(_pattern, _text);
    }

    [Benchmark(Description = "Z-Algorithm search")]
    public IReadOnlyList<int> ZAlgorithm()
    {
        return StringUtils.ZAlgorithm(_text, _pattern);
    }

    [Benchmark(Description = "Rabin–Karp search")]
    public IReadOnlyList<int> RabinKarp()
    {
        return StringUtils.RabinKarpSearch(_text, _pattern);
    }
}
