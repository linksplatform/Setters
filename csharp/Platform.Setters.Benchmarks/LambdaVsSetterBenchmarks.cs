using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
namespace Platform.Setters.Benchmarks
{
    [SimpleJob]
    [MemoryDiagnoser]
    public class LambdaVsSetterBenchmarks
    {
        [GlobalSetup]
        public static void Setup()
        {

        }

        [GlobalCleanup]
        public static void Cleanup()
        {

        }

        int Process(Func<IList<int>, int> func)
        {
            return func(new List<int>{0,1,2,3,4,5,6,7,8,9});
        }

        [Benchmark]
        public int LambdaBenchmark()
        {
            int result;
            var trueValue = 1;
            var falseValue = 2;
            int Lambda(IList<int> list)
            {
                result = list[0];
                return trueValue;
            }
            return Process(Lambda);
        }

        [Benchmark]
        public int SetterBenchmark()
        {
            var setter = new Setter<int, int>(1, 2);
            return Process(setter.SetFirstAndReturnTrue);
        }

    }

}

