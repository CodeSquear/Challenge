using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using ChallengeProblemBigO.ArrayAndHashingBenchMark;
using ChallengeProblemBigO.BinarySearch;
using ChallengeProblemSolution.LinkedList._001;
using Solution001Benchmark = ChallengeProblemBigO.LinkedListBenchMark.Solution001Benchmark;

/*BenchmarkSwitcher
    .FromAssembly(Assembly.GetExecutingAssembly())
    .Run(args);
*/


// Contains Duplicate Problem Benchmark 001
/*BenchmarkRunner.Run<Solution001Benchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);*/

// Is Anagram Problem Benchmark 002
/*BenchmarkRunner.Run<Solution002Benchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);*/

// TwoSum Problem Benchmark 003 
/*BenchmarkRunner.Run<Solution003Benchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)    
);*/

// ReverseList Problem Benchmark 001 
/*BenchmarkRunner.Run<Solution001Benchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);*/

// Is Palindrome String Problem Benchmark 001
/*BenchmarkRunner.Run<ChallengeProblemBigO.TwoPointerBenchMark.Solution001Benchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);*/

// Transform Array Problem Benchmark 001
/*BenchmarkRunner.Run<SolutionTransformArrayBenchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);*/

// Search Problem Benchmark 001
BenchmarkRunner.Run<SolutionSearchBenchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);