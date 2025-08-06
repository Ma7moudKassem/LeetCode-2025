
int[] prices = [1, 3, 7, 10, 3];
Console.WriteLine(MaxProfit(prices));

//Optimal -> Time: O(N)
int MaxProfit(int[] prices)
{
    int minDay = int.MaxValue;
    int maxProfit = 0;
    foreach (int price in prices)
    {
        if (price < minDay)
            minDay = price;
        else
        {
            maxProfit = Math.Max(maxProfit, price - minDay);
        }
    }
   

    return maxProfit;
}

//Brute-Force Time -> O(n^2)
//int MaxProfit(int[] prices)
//{
//    int n = prices.Length;
//    int maxProfit = 0, end = n - 1;

//    for (int i = 0; i < n; i++)
//    {
//        int start = i + 1;
//        if (start >= prices.Length)
//            break;

//        var sellDays = prices[start..];

//        int profit = sellDays.Max() - prices[i];

//        maxProfit = int.Max(maxProfit, profit);
//    }

//    return maxProfit;
//}