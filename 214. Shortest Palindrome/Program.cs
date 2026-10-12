string text = "abcd";
Console.WriteLine($"IsPalindrome: {ShortestPalindrome(text)}");

string ShortestPalindrome(string s)
{
    int n = s.Length;

    string reversed = new([.. s.Reverse()]);

    string campined = s + "#" + reversed;

    var lps = PrefixFunction(campined);

    int longestPrefix = lps[campined.Length - 1];

    string newPrefix = reversed.Substring(0, n - longestPrefix);

    return newPrefix + s;
}

int[] PrefixFunction(string s)
{
    int n = s.Length;

    int[] lps = new int[n];

    for (int i = 1; i < n; i++)
    {
        int j = lps[i - 1];

        while (j > 0 && (s[i] != s[j]))
            j = lps[j - 1];

        if (s[i] == s[j])
            j++;

        lps[i] = j;
    }

    return lps;
}