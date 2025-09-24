Console.WriteLine(WordPattern("abba", "dog cat cat dog"));

bool WordPattern(string pattern, string s)
{
    List<string> words = [.. s.Split(' ')];

    if (pattern.Length != words.Count)
        return false;

    Dictionary<string, int> wordsMap = [];
    int[] pMap = new int[26];

    for (int i = 0; i < words.Count; i++)
    {
        wordsMap.TryAdd(words[i], i + 1);

        int c = pattern[i] - 'a';
        if (pMap[c] == 0)
            pMap[c] = i + 1;

        if (pMap[c] != wordsMap[words[i]])
            return false;
    }

    return true;
}