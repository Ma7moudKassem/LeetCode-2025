foreach (int n in TwoSum([2, 7, 11, 15], 18))
{
    Console.WriteLine(n);
}

int[] TwoSum(int[] numbers, int target)
{
    int i = 0, j = numbers.Length - 1;
    while (i < j)
    {
        int sum = numbers[i] + numbers[j];
        if (sum == target)
            return [i, j];

        if (sum > target)
            j--;
        else i++;
    }

    return [-1, -1];
}

//O(n) space
int[] TwoSumWithMoreSpace(int[] numbers, int target)
{
    Dictionary<int, int> map = [];

    for (int i = 0; i < numbers.Length; i++)
    {
        int temp = target - numbers[i];

        if (map.ContainsKey(numbers[i]))
            return [i, map[numbers[i]]];

        map.Add(temp, i);
    }

    return [-1, -1];
}