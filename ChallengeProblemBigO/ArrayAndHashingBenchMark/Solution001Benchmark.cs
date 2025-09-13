using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeProblemBigO.ArrayAndHashingBenchMark;

[MemoryDiagnoser]
[ShortRunJob]
public class Solution001Benchmark
{
    private readonly Solution001 _solution = new Solution001();

    private int[] _arrayWithDuplicates;
    private int[] _arrayWithoutDuplicates;

    [GlobalSetup]
    public void Setup()
    {
        _arrayWithDuplicates = Enumerable.Repeat(42, 10_000).ToArray();
        _arrayWithoutDuplicates = Enumerable.Range(1, 10_000).ToArray();
    }


    [Benchmark(Description = "Array With Duplicates")]
    public bool WithDuplicates() => _solution.hasDuplicate(_arrayWithDuplicates);

    [Benchmark(Description = "Array Without Duplicates")]
    public bool WithoutDuplicates() => _solution.hasDuplicate(_arrayWithoutDuplicates);
}