Console.WriteLine(ContainsNearbyDuplicate([1, 2, 3, 1, 2, 3], 2));

bool ContainsNearbyDuplicate(int[] nums, int k)
{
    Dictionary<int, int> map = [];
    for(int i = 0; i < nums.Length; i++)
    {
        int num = nums[i];
        if (map.TryGetValue(num, out int value) && Math.Abs(value - i) <= k)
            return true;

        map[num] = i;
    }

    return false;
}