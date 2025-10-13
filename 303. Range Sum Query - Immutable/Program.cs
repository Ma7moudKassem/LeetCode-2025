var arr = new NumArray([-2, 0, 3, -5, 2, -1]);


class NumArray
{
    private int[] _nums;
    public NumArray(int[] nums)
    {
        int[] sums = new int[nums.Length];
        sums[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
            sums[i] = nums[i] + sums[i - 1];

        _nums = sums;
    }

    public int SumRange(int left, int right)
    {
        if (left == 0)
            return _nums[right];

        return _nums[right] - _nums[left - 1];
    }
}
