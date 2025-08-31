int[] ratings = [1, 3, 2, 2, 1];

Console.WriteLine(Candy(ratings));
int Candy(int[] ratings)
{
    int n = ratings.Length;
    int[] candies = new int[n];

    for (int i = 0; i < n; i++)
        candies[i] = 1;

    for (int i = 1; i < ratings.Length; i++)
    {
        if (ratings[i] > ratings[i - 1])
            candies[i] = candies[i - 1] + 1;
    }

    for (int i = n - 2; i >= 0; i--)
    {
        if (ratings[i] > ratings[i + 1])
            candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
    }

    return candies.Sum();
}