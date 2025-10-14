
using System;

Console.WriteLine(NumberOfGoodSubarraySplits([0, 1, 0]));
int NumberOfGoodSubarraySplits(int[] nums)
{
    long ways = 1, gap = 0, prev = -1, mod = (long)Math.Pow(10, 9) + 7;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 1)
        {
            gap = i - prev;

            if (prev > -1) ways = (ways * gap) % mod;

            prev = i;
        }
    }

    if (prev == -1)
        return 0;

    return (int)(ways % mod);
}