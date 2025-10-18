
int[] RunningSum(int[] nums)
{
    int n = nums.Length;
    int[] prefix = new int[n];
    prefix[0] = nums[0];

    for (int i = 1; i < n; i++)
        prefix[i] = prefix[i - 1] + nums[i];

    return prefix;
}