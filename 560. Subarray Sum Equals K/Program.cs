Console.WriteLine(SubarraySum([1, 2, 1, 2, 1], 3));

int SubarraySum(int[] nums, int k)
{
    int count = 0;
    int sum = 0;

    Dictionary<int, int> map = [];
    map.Add(0, 1);

    foreach (int num in nums)
    {
        sum += num;

        if (map.ContainsKey(sum - k))
            count += map[sum - k];

        if (map.ContainsKey(sum))
            map[sum]++;
        else
            map[sum] = 1;
    }
    return count;
}