using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeProblemBigO.ArrayAndHashingBenchMark;

[MemoryDiagnoser]
[ShortRunJob]
public class SolutionTransformArrayBenchmark
{
    private readonly SolutionTransformArray _solution = new SolutionTransformArray();

    private int[] smallArray;
    private int[] largeArray;
    private int[] bigArray;

    [GlobalSetup]
    public void Setup()
    {
        smallArray = Enumerable.Range(1, 10).ToArray();
        largeArray = Enumerable.Range(1, 1_000).ToArray();
        bigArray = Enumerable.Range(1, 10_000).ToArray();
    }

    [Benchmark]
    public int[] SmallArray()
        => _solution.TransformArray(smallArray);

    [Benchmark]
    public int[] LargeArray()
        => _solution.TransformArray(largeArray);

    [Benchmark]
    public int[] BigArray()
        => _solution.TransformArray(bigArray);
}