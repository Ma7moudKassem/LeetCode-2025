
Console.WriteLine(CountSubstrings("CACDNNDLIL"));

int CountSubstrings(string s)
{
    int n = s.Length;

    int res = 0;
    for (int i = 0; i < n; i++)
    {
        res += Palidromic(s, i, i);
        res += Palidromic(s, i, i + 1);
    }

    return res;
}
    

int Palidromic(string s, int left, int right)
{
    int count = 0;
    while (left >= 0 && right < s.Length && s[left] == s[right])
    {
        left--;
        right++;
        count++;
    }

    return count;
}