using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using ChallengeProblemBigO.ArrayAndHashingBenchMark;

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
BenchmarkRunner.Run<Solution003Benchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)    
);