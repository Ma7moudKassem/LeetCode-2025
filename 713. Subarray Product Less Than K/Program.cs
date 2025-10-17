var count = NumSubarrayProductLessThanK([10, 5, 2, 6], 100);
int NumSubarrayProductLessThanK(int[] nums, int k)
{
    List<List<int>> subArrays = [];
    int sum = 0, n = nums.Length;
    for (int i = 0; i < n; i++)
    {
        if (sum + nums[i] >= k)
            continue;

        List<int> arr = [nums[i]];
        subArrays.Add(arr);
        for (int j = i + 1; j < n; j++)
        {
            int arrSum = arr.Sum() + sum;
            if (arrSum + nums[j] >= k)
                break;

            arr = [.. arr, nums[j]];
            sum = arrSum + nums[j];
            subArrays.Add(arr);
        }
    }

    return subArrays.Count == 0 ? 0 : subArrays.Count - 1;
}