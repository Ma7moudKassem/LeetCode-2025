var c = XorQueries([15, 8, 8, 8, 15], [[2, 2], [3, 3]]);

Console.WriteLine();
int[] XorQueries(int[] arr, int[][] queries)
{
    int n = arr.Length;
    int[] prefix = new int[arr.Length + 1];

    prefix[0] = arr[0];
    for (int i = 1; i < n; i++)
        prefix[i] = prefix[i - 1] ^ arr[i];

    int[] result = new int[queries.Length];
    int j = 0;
    foreach (int[] query in queries)
    {
        int left = query[0], right = query[1];

        int xorRes = left == 0 ? prefix[right] : prefix[right] ^ prefix[left-1];

        result[j] = xorRes;
        j++;
    }

    return result;
}


//int[] XorQueries(int[] arr, int[][] queries)
//{
//    int i = 0;
//    int[] result = new int[queries.Length];
//    foreach (int[] query in queries)
//    {
//        int left = query[0], right = query[1];

//        int xorRes = 0;
//        while (left <= right)
//        {
//            xorRes ^= arr[left];
//            left++;
//        }

//        result[i] = xorRes;
//        i++;
//    }

//    return result;
//}
