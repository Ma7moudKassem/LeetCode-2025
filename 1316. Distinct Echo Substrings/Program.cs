

Console.WriteLine(DistinctEchoSubstrings("leetcodeleetcode"));
int DistinctEchoSubstrings(string text)
{
    int n = text.Length;

    HashSet<string> set = [];
    for (int i = 0; i < n; i++)
    {
        for (int j = 1; i + 2 * j <= n; j++)
        {
            var r = text.Substring(i, j);
            var l = text.Substring(i + j, j);

            if (r == l)
            {
                set.Add(r + l);
            }
        }

    }

    return set.Count;
}


int[] CalculatePrefixFunction(string s)
{
    int n = s.Length;
    int[] lps = new int[n];

    for (int i = 1; i < n; i++)
    {
        int j = lps[i - 1];
        while (i < j && s[i] != s[j])
            j = lps[j - 1];

        if (s[i] == s[j])
            j++;

        lps[i] = j;
    }

    return lps;
}