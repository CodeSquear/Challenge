using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeProblemBigO.ArrayAndHashingBenchMark;

[MemoryDiagnoser]
[ShortRunJob]
public class Solution003Benchmark
{
    private readonly Solution003 _solution = new Solution003();

    private int[] smallArray;
    private int[] largeArray;

    [GlobalSetup]
    public void Setup()
    {
        smallArray = Enumerable.Range(1, 10).ToArray();
        largeArray = Enumerable.Range(1, 1_000).ToArray();
    }

    [Benchmark]
    public int[] SmallArray()
        => _solution.TwoSum(smallArray, 19);

    [Benchmark]
    public int[] LargeArray()
        => _solution.TwoSum(largeArray, 210);
}