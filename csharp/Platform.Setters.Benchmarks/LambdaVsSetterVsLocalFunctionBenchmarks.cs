using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace Platform.Setters.Benchmarks
{
    [SimpleJob]
[MemoryDiagnoser]
public class LambdaVsSetterVsLocalFunctionBenchmarks
{
    private int Process(Func<IList<int>, int> func) => func(new List<int> { 0, 1, 2, 3 });

    [Benchmark]
    public int LocalFunctionBenchmark()
    {
        int result;
        var trueValue = 1;
        var falseValue = 2;
        int LocalFunction(IList<int> list)
        {
            result = list[0];
            return trueValue;
        }
        return Process(LocalFunction);
    }

    [Benchmark]
    public int SetterBenchmark()
    {
        var setter = new Setter<int, int>(1, 2);
        return Process(setter.SetFirstAndReturnTrue);
    }

        [Benchmark]
    public int LambdaBenchmark()
    {
        int result;
        var trueValue = 1;
        var falseValue = 2;
        return Process((list) => {
            result = list[0];
            return trueValue;
        });
    }
}
}


