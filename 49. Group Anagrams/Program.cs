
//string[] strs = ["eats", "tea", "tan", "ate", "nat", "bat"];
string[] strs = ["duh", "ill"];

GroupAnagrams(strs);

IList<IList<string>> GroupAnagrams(string[] strs)
{
    Dictionary<string, IList<string>> map = [];
    foreach (var str in strs)
    {
        int[] count = new int[26];
        foreach (char c in str)
            count[c - 'a']++;

        string key = string.Join(",", count);

        if (!map.ContainsKey(key))
            map.Add(key, [str]);
        else
            map[key].Add(str);
    }

    return [..map.Values];
}