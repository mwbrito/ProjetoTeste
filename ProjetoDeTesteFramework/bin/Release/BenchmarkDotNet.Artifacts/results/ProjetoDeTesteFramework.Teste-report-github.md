```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12400F, 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.8.1 (4.8.9181.0), X86 LegacyJIT [AttachedDebugger]
  DefaultJob : .NET Framework 4.8.1 (4.8.9181.0), X86 LegacyJIT


```
| Method                        | Mean           | Error        | StdDev       | Rank | Gen0   | Gen1   | Allocated |
|------------------------------ |---------------:|-------------:|-------------:|-----:|-------:|-------:|----------:|
| TesteComListaContains         | 3,643,079.2 μs | 57,333.77 μs | 61,346.49 μs |    5 |      - |      - |         - |
| TesteComListaContainsParallel |   729,815.3 μs | 13,874.66 μs | 14,248.26 μs |    4 |      - |      - |  139264 B |
| TesteComListaAny              |       143.8 μs |      2.86 μs |      7.96 μs |    1 |      - |      - |      58 B |
| TesteComHashSet               |       734.1 μs |     14.36 μs |     16.54 μs |    2 |      - |      - |         - |
| TesteComHashSetParallel       |     2,328.3 μs |     66.43 μs |    194.82 μs |    3 | 7.8125 | 7.8125 |   46060 B |
