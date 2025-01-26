using System.Diagnostics;
using dotnet_tpl;

int iterations = 50_000;

var sw1 = Stopwatch.StartNew();
var result1 = AlgorithmExecutor.ExecuteAlgorithm(iterations); // runs in 3096ms
sw1.Stop();

var sw2 = Stopwatch.StartNew();
var result2 = TplAlgorithmExecutor.ExecuteAlgorithm(iterations); // runs in 1648ms
sw2.Stop();

var sw3 = Stopwatch.StartNew();
var result3 = await TplAlgorithmExecutorV2.ExecuteAlgorithm(iterations); // runs in 1597ms
sw3.Stop();

var sw4 = Stopwatch.StartNew();
var result4 = await TplAlgorithmExecutorV3.ExecuteAlgorithm(iterations); // runs in 1591ms
sw4.Stop();

Console.WriteLine($"Result of normal algorithm: {result1}");
Console.WriteLine($"Algorithm ran in {sw1.ElapsedMilliseconds} ms");
Console.WriteLine("----------------------------------------------");

Console.WriteLine($"Result of tpl algorithm: {result2}");
Console.WriteLine($"Algorithm ran in {sw2.ElapsedMilliseconds} ms");
Console.WriteLine("----------------------------------------------");

Console.WriteLine($"Result of tpl v2 (added async/await with lock) algorithm: {result3}");
Console.WriteLine($"Algorithm ran in {sw3.ElapsedMilliseconds} ms");
Console.WriteLine("----------------------------------------------");

Console.WriteLine($"Result of tpl v3 (added async/await with concurrent bag) algorithm: {result4}");
Console.WriteLine($"Algorithm ran in {sw4.ElapsedMilliseconds} ms");
Console.WriteLine("----------------------------------------------");