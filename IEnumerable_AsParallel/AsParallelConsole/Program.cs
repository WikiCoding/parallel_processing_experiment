using System.Diagnostics;

var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine($"Running on {Thread.CurrentThread.ManagedThreadId}");

var stopWatch = Stopwatch.StartNew();
var enumerable = list.AsParallel().Where(i => i % 2 == 0).Select(i =>
{
  Console.WriteLine($"Squaring {i} on thread {Thread.CurrentThread.ManagedThreadId}");
  return i * i;
}).ToList();
stopWatch.Stop();

Console.WriteLine($"Running on back at {Thread.CurrentThread.ManagedThreadId}");

Console.WriteLine($"Time taken: {stopWatch.ElapsedMilliseconds}ms");
