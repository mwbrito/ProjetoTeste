```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-12400F, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2


```
| Method                | Mean                 | Error             | StdDev            | Rank | Gen0   | Allocated |
|---------------------- |---------------------:|------------------:|------------------:|-----:|-------:|----------:|
| TesteComListaAny      |            29.245 ns |         0.2719 ns |         0.2544 ns |    2 | 0.0110 |     104 B |
| TesteComHashSet       |             1.796 ns |         0.0172 ns |         0.0144 ns |    1 |      - |         - |
| TesteComListaContains | 2,798,502,233.333 ns | 9,767,576.4014 ns | 9,136,597.0261 ns |    3 |      - |   14664 B |
