using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.LinkedList._001;
using ChallengeTesting.LinkedListTests.Helper;

namespace ChallengeProblemBigO.LinkedListBenchMark;

[MemoryDiagnoser]
[ShortRunJob]
public class Solution001Benchmark
{
    private ListNode headSmall;
    private ListNode headMedium;
    private ListNode headLarge;

    private Solution001 solution;

    [GlobalSetup]
    public void Setup()
    {
        solution = new Solution001();

        headSmall = ListNodeHelper.FromList(GenerateList(10));
        headMedium = ListNodeHelper.FromList(GenerateList(1000));
        headLarge = ListNodeHelper.FromList(GenerateList(100_000));
    }

    [Benchmark]
    public void Reverse_SmallList() =>
        solution.ReverseList(headSmall);

    [Benchmark]
    public void Reverse_MediumList() =>
        solution.ReverseList(headMedium);
    

    [Benchmark]
    public void Reverse_LargeList() =>
        solution.ReverseList(headLarge);
    

    private List<int> GenerateList(int size)
    {
        var list = new List<int>(size);
        for (int i = 0; i < size; i++)
        {
            list.Add(i);
        }
        return list;
    }
}
