```

BenchmarkDotNet v0.15.6, macOS 26.0.1 (25A362) [Darwin 25.0.0]
Apple M4 Pro, 1 CPU, 12 logical and 12 physical cores
.NET SDK 8.0.414
  [Host]     : .NET 8.0.20 (8.0.20, 8.0.2025.41914), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.20 (8.0.20, 8.0.2025.41914), Arm64 RyuJIT armv8.0-a


```
| Method          | Mean      | Error    | StdDev   |
|---------------- |----------:|---------:|---------:|
| Approach_Sort   | 118.00 ns | 0.753 ns | 0.705 ns |
| Approach_Shrink |  37.85 ns | 0.317 ns | 0.281 ns |
