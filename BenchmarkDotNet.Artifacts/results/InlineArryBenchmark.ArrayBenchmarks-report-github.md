```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3624)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2


```
| Method           | Mean      | Error     | StdDev    | Ratio | RatioSD | Gen0    | Allocated | Alloc Ratio |
|----------------- |----------:|----------:|----------:|------:|--------:|--------:|----------:|------------:|
| TraditionalArray | 10.943 μs | 0.7702 μs | 2.1848 μs |  1.04 |    0.28 | 13.5956 |   64000 B |        1.00 |
| InlineArray      |  7.305 μs | 0.1854 μs | 0.5466 μs |  0.69 |    0.14 |       - |         - |        0.00 |
