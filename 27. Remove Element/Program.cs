
int[] nums = [3,3];

Console.WriteLine(RemoveElement(nums, 2));

int RemoveElement(int[] nums, int val)
{
    int i = 0, j = 0;

    while (j < nums.Length)
    {
        if (nums[j] != val)
        {
            if (i != j)
                Swap(nums, i, j);
            i++;
        }

        j++;
    }

    return i;
}
static void Swap(int[] nums, int i, int j)
{
    (nums[j], nums[i]) = (nums[i], nums[j]);
}