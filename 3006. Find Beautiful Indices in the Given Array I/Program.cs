var v = BeautifulIndices("isawsquirrelnearmysquirrelhouseohmy", "my", "squirrel", 15);

Console.WriteLine();
IList<int> BeautifulIndices(string s, string a, string b, int k)
{
    List<int> aIndeces = [];
    int index = s.IndexOf(a);
    while (index != -1)
    {
        aIndeces.Add(index);
        index = s.IndexOf(a, index + 1);
    }

    List<int> bIndeces = [];
    index = s.IndexOf(b);
    while (index != -1)
    {
        bIndeces.Add(index);
        index = s.IndexOf(b, index + 1);
    }

    List<int> res = [];

    // |i - j| <= k

    // i <= j + k

    // -j <= -i + k 

    //j >= i - k

    foreach (int i in aIndeces)
    {
        int j = 0;

        while (j < bIndeces.Count && bIndeces[j] < i - k)
            j++;

        if (j < bIndeces.Count && bIndeces[j] >= i - k)
            res.Add(i);
    }

    return res;
}

