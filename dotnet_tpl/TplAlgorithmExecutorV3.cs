using System.Collections.Concurrent;

namespace dotnet_tpl;

public class TplAlgorithmExecutorV3
{
    public static async Task<long> ExecuteAlgorithm(int iterations)
    {
        ConcurrentBag<long> bag = [];

        await Task.Run(() => 
        {
            Parallel.Invoke(
                () => bag.Add(Algorithm(iterations)),
                () => bag.Add(Algorithm(iterations))
            );
        });

        return bag.Sum();
    }

    private static long Algorithm(int iterations)
    {
        long sum = 0;

        for (int i = 0; i < iterations; i++)
        {
            sum++;
            for (int j = 0; j < iterations; j++)
            {
                // just slowing down this
            }
        }

        return sum;
    }    
}