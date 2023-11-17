```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12400F, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2


```
| Method                        | Mean           | Error        | StdDev       | Rank | Gen0    | Gen1   | Allocated |
|------------------------------ |---------------:|-------------:|-------------:|-----:|--------:|-------:|----------:|
| TesteComListaContains         | 2,613,747.7 μs | 12,816.25 μs | 11,988.32 μs |    4 |       - |      - |    5408 B |
| TesteComListaContainsParallel |   534,983.5 μs |  4,736.87 μs |  4,430.87 μs |    3 |       - |      - |    6160 B |
| TesteComHashSet               |       560.6 μs |      3.41 μs |      3.03 μs |    1 |       - |      - |       1 B |
| TesteComHashSetParallel       |       985.8 μs |     33.05 μs |     97.46 μs |    2 | 11.7188 | 0.9766 |  103629 B |
