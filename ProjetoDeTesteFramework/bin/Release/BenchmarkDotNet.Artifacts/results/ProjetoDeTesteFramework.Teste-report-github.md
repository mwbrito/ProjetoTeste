```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12400F, 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.8.1 (4.8.9181.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8.1 (4.8.9181.0), X86 LegacyJIT


```
| Method                        | Mean           | Error        | StdDev       | Rank | Gen0   | Gen1   | Allocated |
|------------------------------ |---------------:|-------------:|-------------:|-----:|-------:|-------:|----------:|
| TesteComListaContains         | 3,141,521.6 μs |  8,232.29 μs |  7,700.49 μs |    4 |      - |      - |         - |
| TesteComListaContainsParallel |   596,536.5 μs | 11,663.00 μs | 18,498.76 μs |    3 |      - |      - |  147456 B |
| TesteComHashSet               |       672.8 μs |      2.83 μs |      2.64 μs |    1 |      - |      - |         - |
| TesteComHashSetParallel       |     2,260.4 μs |     32.68 μs |     28.97 μs |    2 | 3.9063 | 3.9063 |   33926 B |
