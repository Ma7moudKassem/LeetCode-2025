int[] arr = new int[] { 10, 13, 12, 14, 15 };


Console.WriteLine(OddEvenJumps(arr));



int OddEvenJumps(int[] arr)
{
    int n = arr.Length;

    int[] odd = new int[n];
    int[] even = new int[n];

    int Dfs(int i)
    {
        if (odd[i] != 0 || even[i] != 0)
            return Math.Max(odd[i], even[i]);
        
        odd[i] = 1;
        even[i] = 1;

        // Odd jump
        for (int j = i + 1; j < n; j++)
        {
            bool isEven = (j + 1) % 2 == 0;
            if (isEven)
            {
                if (arr[i] < arr[j])
                    break;

                even[i] = Math.Max(even[i], 1 + Dfs(j));
            }
            else
            {
                if (arr[i] > arr[j])
                    break;

                odd[i] = Math.Max(odd[i], 1 + Dfs(j));
            }
        }

        return Math.Max(odd[i], even[i]);
    }

    int goodJumpes = 0;

    for (int i = 0; i < n; i++)
    {
        goodJumpes = Math.Max(goodJumpes, Dfs(i));
    }

    return goodJumpes;
}