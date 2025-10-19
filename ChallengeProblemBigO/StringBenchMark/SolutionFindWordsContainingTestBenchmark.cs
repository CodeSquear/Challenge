using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.String;

namespace ChallengeProblemBigO.StringBenchMark;

[ShortRunJob]
[MemoryDiagnoser]
public class SolutionFindWordsContainingTestBenchmark
{
    private readonly SolutionFindWordsContaining _solution
        = new SolutionFindWordsContaining();

    private string[] _smallWords;
    private string[] _mediumWords;
    private string[] _largeWords;

    private char _targetChar = 'e';

    [GlobalSetup]
    public void Setup()
    {
        _smallWords = Enumerable.Range(0, 10)
            .Select(i => "word" + i + "example")
            .ToArray();

        _mediumWords = Enumerable.Range(0, 1000)
            .Select(i => "word" + i + "example")
            .ToArray();

        _largeWords = Enumerable.Range(0, 100000)
            .Select(i => "word" + i + "example")
            .ToArray();
    }

    [Benchmark]
    public void Benchmark_SmallInput()
    =>
        _solution.FindWordsContaining(_smallWords, _targetChar);
    

    [Benchmark]
    public void Benchmark_MediumInput()
    =>
        _solution.FindWordsContaining(_mediumWords, _targetChar);

    [Benchmark]
    public void Benchmark_LargeInput()
    =>
        _solution.FindWordsContaining(_largeWords, _targetChar);
}