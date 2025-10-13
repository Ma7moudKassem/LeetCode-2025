Console.WriteLine(NumOfSubarrays([1, 2, 3, 4, 5, 6, 7]));

int NumOfSubarrays(int[] arr)
{
    long even = 1, odd = 0, perfix = 0, count = 0;

    long mod = (long)Math.Pow(10, 9) + 7;
    foreach (int nums in arr)
    {
        perfix += nums;

        if (perfix % 2 == 0)
        {
            even++;
            count += odd;
        }
        else
        {
            odd++;
            count += even;
        }
    }

    return (int)(count % mod);
}