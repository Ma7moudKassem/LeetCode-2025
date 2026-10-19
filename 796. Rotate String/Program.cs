
Console.WriteLine(RotateString("abcde", "abced"));

bool RotateString(string s, string goal)
{
    if (s.Length != goal.Length)
        return false;

    if (s == goal)
        return true;

    string doubleText = s + s;

    return SearchKMP(doubleText, goal);
}

bool SearchKMP(string s, string pattern)
{
    int[] patternLps = BuildLps(pattern);

    int i = 0, j = 0;

    while (i < s.Length)
    {
        if (s[i] == pattern[j])
        {
            i++; j++;

            if (j == pattern.Length)
                return true;
        }
        else if (j > 0)
        {
            j = patternLps[j - 1];
        }
        else
        {
            i++;
        }
    }

    return false;
}
int[] BuildLps(string s)
{
    int n = s.Length;

    int[] lps = new int[n];

    int i = 1, j = 0;

    while (i < n)
    {
        if (s[i] == s[j])
        {
            i++; j++;
            lps[i] = j - 1;
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

    return lps;
}