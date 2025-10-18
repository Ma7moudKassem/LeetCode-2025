var res = ProductExceptSelf([1, 2, 3, 4]);
int[] ProductExceptSelf(int[] nums)
{
    int n = nums.Length;
    int[] leftPrefix = new int[n];

    leftPrefix[0] = 1;
    for (int i = 1; i < n; i++)
        leftPrefix[i] = leftPrefix[i - 1] * nums[i - 1];

    int right = 1;
    for (int i = n - 1; i >= 0; i--)
    {
        leftPrefix[i] *= right;
        right *= nums[i];
    }

    return leftPrefix;
}