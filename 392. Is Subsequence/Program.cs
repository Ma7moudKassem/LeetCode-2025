Console.WriteLine(IsSubsequence("b", "abc"));
bool IsSubsequence(string s, string t)
{
    if (string.IsNullOrEmpty(s))
        return true;

    if (s.Length > t.Length)
        return false;

    int i = 0, j = 0;
    while (i < s.Length && j < t.Length)
    {
        if (s[i] == t[j])
            i++;

        j++;
    }

    return i >= s.Length;
}