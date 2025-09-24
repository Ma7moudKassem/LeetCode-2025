Console.WriteLine(IsIsomorphic("ninve", "title"));

bool IsIsomorphic(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    int[] map1 = new int[256];
    int[] map2 = new int[256];

    for (int i = 0; i < s.Length; i++)
    {
        int c1 = s[i];
        int c2 = t[i];

        if (map1[c1] == 0)
            map1[c1] = i + 1;

        if (map2[c2] == 0)
            map2[c2] = i + 1;

        if (map1[c1] != map2[c2])
            return false;
    }

    return true;
}