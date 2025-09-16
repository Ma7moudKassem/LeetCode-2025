foreach (var n in FindSubstring("barfoothefoobarman", ["foo", "bar"]))
{
    Console.Write($"{n}");
}

IList<int> FindSubstring(string s, string[] words)
{
    IList<int> result = [];
    
    if (s.Length == 0 || words.Length == 0)
        return result;

    int wordSize = words[0].Length;
    int subStringLength = wordSize * words.Length;

    if (subStringLength > s.Length)
        return result;

    var wordCount = new Dictionary<string, int>();
    foreach (var word in words)
    {
        if (!wordCount.TryAdd(word, 1))
            wordCount[word]++;
    }

    for (int i = 0; i < wordSize; i++)
    {
        var windowCount = new Dictionary<string, int>();
        int right = i, left = i;
        int count = 0;
        while (right + wordSize <= s.Length)
        {
            string term = s.Substring(right, wordSize);
            right += wordSize;

            if (wordCount.ContainsKey(term))
            {
                if (!windowCount.TryAdd(term, 1))
                    windowCount[term]++;

                if (windowCount[term] <= wordCount[term])
                    count++;

                while (windowCount[term] > wordCount[term])
                {
                    string leftWord = s.Substring(left, wordSize);

                    windowCount[leftWord]--;
                    if (windowCount[leftWord] < wordCount[leftWord])
                        count--;        

                    left += wordSize;
                }

                if (count == words.Length)
                    result.Add(left);
            }
            else
            {
                count = 0;
                windowCount.Clear();
                left = right;
            }
        }
    }

    return result;
}


string SlidingWindow(string s, int i, int j, ReadOnlySpan<char> span)
{
    if (j < s.Length)
        return span.Slice(i, j).ToString();

    return "";
}
