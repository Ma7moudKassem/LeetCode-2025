ThreeSum([-1, 0, 1, 2, -1, -4]);

IList<IList<int>> ThreeSum(int[] nums)
{
    Array.Sort(nums);// -1, -1, 0, 1
    IList<IList<int>> result = [];
    for (int i = 0; i < nums.Length - 2; i++)
    {
        if (i > 0 && nums[i] == nums[i - 1])
            continue;

        int l = i + 1, j = nums.Length - 1;
        int target = 0 - nums[i];

        while (l < j)
        {
            int sum = nums[l] + nums[j];

            if (sum == target)
            { 
                result.Add([nums[i], nums[l], nums[j]]);
                while (l < j && nums[l] == nums[l + 1])
                    l++;
                while (l < j && nums[j] == nums[j - 1])
                    j--;

                l++;
                j--;
            }
            else if (sum > target)
                j--;
            else
                l++;
        }
    }

    return result;
}