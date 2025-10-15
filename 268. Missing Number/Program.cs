Console.WriteLine(MissingNumber([0, 1]));

int MissingNumber(int[] nums)
{
    int n = nums.Length;
    int[] temp = new int[n + 1];

    foreach (int num in nums)
        temp[num] = num;

    for (int i = 0; i < temp.Length; i++)
        if (temp[i] == 0 && i != 0)
            return i;

    return 0;
}
