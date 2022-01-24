using BenchmarkDotNet.Running;

namespace Platform.Setters.Benchmarks
{
    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<LambdaVsSetterVsLocalFunctionBenchmarks>();
        }
    }
}
