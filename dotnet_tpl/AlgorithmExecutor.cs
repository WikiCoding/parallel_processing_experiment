namespace dotnet_tpl;

public class AlgorithmExecutor
{

    public static long ExecuteAlgorithm(int iterations)
    {
        long sum = Algorithm(iterations);
        sum += Algorithm(iterations);
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