using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeProblemBigO.ArrayAndHashingBenchMark;

[MemoryDiagnoser]
[ShortRunJob]
public class SolutionMaxFrequencyElementsBenchmark
{
    private readonly SolutionMaxFrequencyElements _solution
        = new SolutionMaxFrequencyElements();

    private int[] smallArray;
    private int[] middleArray;
    private int[] largeArray;

    [GlobalSetup]
    public void Setup()
    {
        smallArray = Enumerable.Range(1, 10).ToArray();
        middleArray = Enumerable.Range(1, 1_000).ToArray();
        largeArray = Enumerable.Range(1, 10_000).ToArray();
    }

    [Benchmark]
    public int SmallArray()
        => _solution.MaxFrequencyElements(smallArray);

    [Benchmark]
    public int MiddleArray()
        => _solution.MaxFrequencyElements(middleArray);

    [Benchmark]
    public int LargeArray()
        => _solution.MaxFrequencyElements(largeArray);
}