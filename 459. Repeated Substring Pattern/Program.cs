
Console.WriteLine(RepeatedSubstringPattern("abcabcabcabc"));

bool RepeatedSubstringPattern(string s)
{
    int n = s.Length;
    if (n < 2)
        return false;

    int[] lps = LPS(s);

    int prefix = lps[n - 1];

    int len = n - prefix;

    return n % len == 0 && len < n;
}

int[] LPS(string s)
{
    int n = s.Length;
    int[] lps = new int[n];

    int i = 1, j = 0;
    while (i < n)
    {
        if (s[i] == s[j])
        {
            j++;
            lps[i] = j;
            i++;
        }
        else if (j > 0)
        {
            j = lps[j - 1];
        }
        else
        {
            lps[i] = 0;
            i++;
        }
    }

    return lps;
}