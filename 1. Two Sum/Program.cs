
foreach (var c in TwoSum([3,2,4], 6))
{
    Console.Write($"{c}");
}

int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> map = new Dictionary<int, int>(nums.Length);
    for (int i = 0; i < nums.Length; i++)
        map[target - nums[i]] = i;

    for (int i = 0; i < nums.Length; i++)
        if (map.ContainsKey(nums[i]) && map[nums[i]] != i )
            return [i, map[nums[i]]];

    return [-1, -1];
}

//Refactored Version
//int[] TwoSum(int[] nums, int target)
//{
//    Dictionary<int, int> map = new Dictionary<int, int>(nums.Length);
//    for (int i = 0; i < nums.Length; i++)
//    {
//        int comp = target - nums[i];
//        if (map.TryGetValue(comp, out int index))
//            return [index, i];

//        map[nums[i]] = i;
//    }

//    return [-1, -1];
//}