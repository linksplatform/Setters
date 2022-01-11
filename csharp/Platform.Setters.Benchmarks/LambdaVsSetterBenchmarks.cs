using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace Platform.Setters.Benchmarks;

[SimpleJob]
[MemoryDiagnoser]
public class LambdaVsSetterBenchmarks
{
    private int Process(Func<IList<int>, int> func) => func(new List<int> { 0, 1, 2, 3 });

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
