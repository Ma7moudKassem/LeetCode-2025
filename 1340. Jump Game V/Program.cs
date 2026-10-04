int MaxJumps(int[] arr, int d)
{
    int n = arr.Length;

    int[] dp = new int[n];

    int Dfs(int i)
    {
        if(dp[i] != 0) 
            return dp[i];


        dp[i] = 1;

        //move left
        for (int j = i - 1; j >= Math.Max(0, i - d); j--)
        {
            if (arr[j] >= arr[i])
                break;

            dp[i] = Math.Max(dp[i], 1 + Dfs(j));
        }

        //move right
        for (int j = i + 1; j <= Math.Min(n - 1, i + d); j++)
        {
            if (arr[j] >= arr[i])
                break;

            dp[i] = Math.Max(dp[i], 1 + Dfs(j));
        }

        return dp[i];
    }


    int maxJumps = 0;

    for (int i = 0; i < n; i++)
    {
        maxJumps = Math.Max(maxJumps, Dfs(i));
    }

    return maxJumps;
}

