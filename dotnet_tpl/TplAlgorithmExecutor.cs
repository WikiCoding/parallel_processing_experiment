using System.Runtime.CompilerServices;

namespace dotnet_tpl;

public class TplAlgorithmExecutor
{
    public static long ExecuteAlgorithm(int iterations)
    {
        long sum = 0;
        object lockObject = new object();

        Parallel.Invoke(
            () =>
            {
                long result = Algorithm(iterations);
                lock (lockObject)
                {
                    sum += result;
                }
            },
            () =>
            {
                long result = Algorithm(iterations);
                lock (lockObject)
                {
                    sum += result;
                }
            }
        );

        return sum;
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