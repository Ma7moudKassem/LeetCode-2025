Console.WriteLine(FindDuplicate([1, 3, 4, 2, 2]));

int FindDuplicate(int[] nums)
{
    int fast = nums[0];
    int slow = nums[0];

    do
    {
        fast = nums[nums[fast]];
        slow = nums[slow];
    }
    while (fast != slow);

    slow = nums[0];
    while (slow != fast)
    {
        slow = nums[slow];
        fast = nums[fast];
    }

    return slow;
}