int[] nums = [3, 2, 1, 0, 4];

Console.WriteLine(CanJump(nums));

bool CanJump(int[] nums)
{
    int maxReach = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if(i > maxReach)
            return false;

        maxReach = Math.Max(maxReach, nums[i] + i);
    }

    return true;
}