Console.WriteLine(StrStr("mississippi", "issip"));

int StrStr(string haystack, string needle)
{
    int[] lps = LPS(needle);

    int n = haystack.Length;
    int i = 0, j = 0;

    while (i < n)
    {
        if (haystack[i] == needle[j])
        {
            i++; j++;

            if (j == needle.Length)
                return i - needle.Length;
        }
        else if (j > 0)
        {
            j = lps[j - 1];
        }
        else
        {
            i++;
        }
    }

    return -1;
}


int[] LPS(string pattern)
{
    int n = pattern.Length;
    int[] lps = new int[n];

    int i = 1, j = 0;

    while (i < n)
    {
        if (pattern[i] == pattern[j])
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