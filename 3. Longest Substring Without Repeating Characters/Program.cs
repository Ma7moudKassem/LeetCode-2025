
Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
int LengthOfLongestSubstring(string s)
{
    HashSet<char> uniqueChars = [];

    int length = 0;
    int j = 0;
    for(int i = 0; i < s.Length; i++)
    {
        while (uniqueChars.Contains(s[i]))
            uniqueChars.Remove(s[j++]);

        uniqueChars.Add(s[i]);
        length = Math.Max(length, i - j + 1);
    }

    return length;
}