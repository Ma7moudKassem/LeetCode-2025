Console.WriteLine(PivotIndex([-1, -1, 0, 0, -1, -1]));

int PivotIndex(int[] nums)
{
    int n = nums.Length;
    int total = nums.Sum();

    int leftSum = 0;

    for (int i = 0; i < n; i++)
    {
        int rightSum = total - leftSum - nums[i];
        if (rightSum == leftSum)
            return i;

        leftSum += nums[i];
    }

    return -1;
}