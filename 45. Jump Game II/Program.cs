int[] test = [1, 0, 0, 1, 4];

Console.WriteLine(Jump(test));

int Jump(int[] nums)
{
    if (nums == null || nums.Length < 2) return 0;

    int farthest = 0;
    int jumps = 0;
    int currentEnd = 0;

    for (int i = 0; i < nums.Length - 1; i++)
    {
        farthest = Math.Max(farthest, nums[i] + i);

        if (i == currentEnd)
        {
            jumps++;
            currentEnd = farthest;

            if (currentEnd >= nums.Length - 1)
                break;
        }
    }

    return jumps;
}