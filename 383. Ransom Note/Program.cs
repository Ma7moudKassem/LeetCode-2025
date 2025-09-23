
Console.WriteLine(CanConstruct("aa", "ab"));

//Runtime 1ms Beats 97.97% ---- Memory 46.58 MB Beats 35.72%
bool CanConstruct(string ransomNote, string magazine)
{
    int[] arr = new int[26];
    foreach (char c in magazine)
        arr[c - 'a']++;

    foreach (char ra in ransomNote)
    {
        if (arr[ra - 'a'] <= 0)
            return false;

        arr[ra - 'a']--;
    }

    return true;
}


//Runtime 9ms Beats 48.21% ---- Memory 46.33MB Beats 55.56%

//bool CanConstruct(string ransomNote, string magazine)
//{
//    Dictionary<char, int> magMap = [];
//    foreach (char c in magazine)
//    {
//        if (!magMap.ContainsKey(c))
//            magMap.Add(c, 0);

//        magMap[c]++;
//    }

//    foreach (char ra in ransomNote)
//    {
//        if (!magMap.ContainsKey(ra) || magMap[ra] <= 0)
//            return false;

//        magMap[ra]--;
//    }

//    return true;
//}