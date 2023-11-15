```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12400F, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2


```
| Method                        | Mean            | Error         | StdDev        | Rank | Gen0    | Gen1   | Allocated |
|------------------------------ |----------------:|--------------:|--------------:|-----:|--------:|-------:|----------:|
| TesteComListaContains         | 2,879,471.79 μs | 55,419.090 μs | 72,060.472 μs |    5 |       - |      - |     640 B |
| TesteComListaContainsParallel |   583,472.60 μs | 11,526.160 μs | 14,576.901 μs |    4 |       - |      - |    7336 B |
| TesteComListaAny              |        47.76 μs |      0.911 μs |      0.808 μs |    1 |       - |      - |     104 B |
| TesteComHashSet               |       581.28 μs |     11.586 μs |     15.467 μs |    2 |       - |      - |       1 B |
| TesteComHashSetParallel       |       999.97 μs |     35.423 μs |    104.445 μs |    3 | 12.6953 | 1.9531 |  113665 B |
