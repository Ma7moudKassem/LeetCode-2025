
int[] prices = [7, 1, 5, 3, 6, 4];
Console.WriteLine(MaxProfit(prices));
int MaxProfit(int[] prices)
{
    int profit = 0;
    for (int i = prices.Length -1 ; i > 0; i--)
    {
        if (prices[i] > prices[i - 1])
            profit += prices[i] - prices[i - 1];
    }

    return profit;
}