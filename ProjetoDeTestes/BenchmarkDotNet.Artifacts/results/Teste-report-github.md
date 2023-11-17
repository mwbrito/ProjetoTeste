```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12400F, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2


```
| Method                        | Mean          | Error        | StdDev       | Rank | Gen0    | Gen1   | Allocated |
|------------------------------ |--------------:|-------------:|-------------:|-----:|--------:|-------:|----------:|
| TesteComListaContains         |      23.69 μs |     0.186 μs |     0.165 μs |    1 |       - |      - |         - |
| TesteComListaContainsParallel | 539,647.45 μs | 5,343.401 μs | 4,998.221 μs |    4 |       - |      - |    7624 B |
| TesteComHashSet               |     558.16 μs |     7.796 μs |     6.911 μs |    2 |       - |      - |       1 B |
| TesteComHashSetParallel       |     995.72 μs |    30.795 μs |    90.799 μs |    3 | 11.7188 | 0.9766 |  110274 B |
