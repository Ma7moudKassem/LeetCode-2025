Console.WriteLine(NumSubarraysWithSum([0,0,0,0,0], 0));
int NumSubarraysWithSum(int[] nums, int goal)
{
    int sum = 0, count = 0;

    Dictionary<int, int> map = [];
    map.Add(0, 1);
    foreach (int num in nums)
    {
        sum += num;

        if (map.ContainsKey(sum - goal))
            count += map[sum - goal];

        if (map.ContainsKey(sum))
            map[sum]++;
        else map[sum] = 1;
    }

    return count;
}