Console.WriteLine(FindMaxLength([0, 1, 1, 1, 1, 1, 0, 0, 0]));

int FindMaxLength(int[] nums)
{
    int length = 0;
    int sum = 0;

    Dictionary<int, int> map = [];
    map.Add(0, -1);
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i] == 1 ? 1 : -1;
        if (map.ContainsKey(sum))
        {
            int idx = map[sum];
            length = Math.Max(length, i - idx);
        }
        else
            map[sum] = i;
    }

    return length;
}