
Console.WriteLine(IsAnagram("anagram", "nagaram"));
bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    int[] chars = new int[26];

    foreach (char c in s)
        chars[c - 'a']++;

    foreach (char c in t)
    {
        if (chars[c - 'a'] == 0)
            return false;

        chars[c - 'a']--;
    }

    return true;
}