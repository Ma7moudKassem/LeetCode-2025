Console.WriteLine(TotalFruit([3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4]));

int TotalFruit(int[] fruits)
{
    int n = fruits.Length;
    int maxAmount = 0;

    Dictionary<int, int> baskets = [];
    int j = 0;
    for (int i = 0; i < n; i++)
    {
        int fruit = fruits[i];
        if (!baskets.TryGetValue(fruit, out _))
            baskets[fruit] = 0;

        baskets[fruit]++;

        while (baskets.Count > 2)
        {
            int ignored = fruits[j];
            baskets[ignored]--;

            if (baskets[ignored] == 0)
                baskets.Remove(ignored);

            j++;
        }

        maxAmount = Math.Max(maxAmount, i - j + 1);
    }

    return maxAmount;
}