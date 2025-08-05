int[] nums = { 1, 2, 3, 4, 5, 6, 7 }; // {1,2,3,4,5,6,7}

Rotate(nums, 6);

foreach (var num in nums)
{
    Console.Write(num + " ");
}

void Rotate(int[] nums, int k)
{
    int n = nums.Length;
    k %= n;
    //k < n -> k
    //k = n + x -> x
    //k = 0 -> 0
    //k = n -> 0
    
    Reverse(nums, 0, n - 1);
    Reverse(nums, 0, k - 1);
    Reverse(nums, k, n - 1);
}

void Reverse(int[] nums, int left, int right)
{
    while (left < right)
    {
        (nums[left], nums[right]) = (nums[right], nums[left]);
        left++;
        right--;
    }
}