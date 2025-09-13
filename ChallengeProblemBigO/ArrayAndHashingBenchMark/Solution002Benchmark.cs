using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeProblemBigO.ArrayAndHashingBenchMark;

[MemoryDiagnoser]
[ShortRunJob]
public class Solution002Benchmark
{
    private readonly Solution002 _solution = new Solution002();

    private string _s1;
    private string _t1;
    private string _s2;
    private string _t2;


    [GlobalSetup]
    public void Setup()
    {
        _s1 = "aaaaaaaaaaaaaaaab";
        _t1 = "baaaaaaaaaaaaaaaa";

        _s2 = "raaat";
        _t2 = "taaar";
    }

    [Benchmark(Description = "IsAnagram_True_Case")]
    public bool IsAnagram_Returns_CaseOne()
        => _solution.IsAnagram(_s1, _t1);

    [Benchmark(Description = "IsAnagram_True_Case")]
    public bool IsAnagram_Returns_CaseTwo()
        => _solution.IsAnagram(_s1, _t1);

    [Benchmark(Description = "IsAnagram_True_False")]
    public bool IsAnagram_Returns_CaseThere()
        => _solution.IsAnagram(_s2, _t1);

    [Benchmark(Description = "IsAnagram_True_False")]
    public bool IsAnagram_Returns_CaseFour()
        => _solution.IsAnagram(_s1, _t2);
}