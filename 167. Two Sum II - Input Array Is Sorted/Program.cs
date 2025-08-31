foreach (int n in TwoSum([2,7,11,15], 18))
{
    Console.WriteLine(n);
}

int[] TwoSum(int[] numbers, int target)
{
    int i = 0, j = numbers.Length - 1;
    while (i != j)
    {
        int sum = numbers[i] + numbers[j];

        if (sum == target)
            return [i + 1, j + 1];

        if (sum > target)
            j--;
        else
            i++;
    }

    return [-1, -1];
}