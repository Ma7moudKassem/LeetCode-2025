int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

Console.WriteLine(RemoveDuplicates(nums));

int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 0)
        return 0;

    int i = 0; // pointer for the last unique element

    for (int j = 1; j < nums.Length; j++)
    {
        if (nums[j] != nums[i])
        {
            i++;
            nums[i] = nums[j];
        }
    }

    return i + 1;
}

//Brute Force approuch Space O(n)

//int RemoveDuplicates(int[] nums)
//{
//    HashSet<int> set = new HashSet<int>(nums);

//    int i = 0;
//    foreach (int num in set)
//    {
//        nums[i++] = num;    
//    }

//    return i;
//}