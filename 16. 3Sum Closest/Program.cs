Console.WriteLine(ThreeSumClosest([-1, 2, 1, -4], 1));

int ThreeSumClosest(int[] nums, int target)
{
    Array.Sort(nums);

    int n = nums.Length;
    int result = int.MaxValue;

    for (int i = 0; i < n; i++)
    {
        int left = i + 1, right = n - 1;

        while (left < right)
        {
            int sum = nums[i] + nums[left] + nums[right];

            if (Math.Abs(target - sum) < Math.Abs(target - result))
                result = sum;

            if (sum < target)
                left++;
            else if (sum > target)
                right--;
            else return sum;
        }
    }

    return result;
}