Console.WriteLine(LongestConsecutive([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]));

int LongestConsecutive(int[] nums)
{
    if (nums.Length == 0)
        return 0;

    int longest = 0;
    HashSet<int> set = [.. nums];

    foreach (int num in set)
    {
        int streck = 0;
        int current = 0;
        if (!set.Contains(num - 1))
        {
            current = num;
            streck = 1;

            while (set.Contains(current + 1))
            {
                streck++;
                current++;
            }
        }

        longest = Math.Max(longest, streck);
    }

    return longest;
}
