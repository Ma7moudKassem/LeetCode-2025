Console.WriteLine(SubarraySum([1, 2, 3], 3));

int SubarraySum(int[] nums, int k)
{
    int n = nums.Length;
    int count = 0;

    Dictionary<int, int> map = [];

    map.Add(0, 1);
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += nums[i];

        int diff = sum - k;
        if (map.ContainsKey(diff))
            count += map[diff];

        if (map.ContainsKey(sum))
            map[sum]++;
        else
            map.Add(sum, 1);
    }

    return count;
}