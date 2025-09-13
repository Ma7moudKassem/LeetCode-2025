using System.ComponentModel.Design;

Console.WriteLine(MinSubArrayLen(7, [2, 3, 1, 2, 4, 3]));
// 2, 4, 12, 12, 25, 25, 25, 25, 25, 26, 28, 83 
int MinSubArrayLen(int target, int[] nums)
{
    int i = 0, j = 0, length = int.MaxValue;

    int sum = 0;
    while (j < nums.Length)
    {
        sum += nums[j];
        while (sum >= target)
        {
            length = Math.Min(length, j - i + 1);
            sum -= nums[i];

            i++;
        }
        j++;
    }

    return length == int.MaxValue ? 0 : length;
}