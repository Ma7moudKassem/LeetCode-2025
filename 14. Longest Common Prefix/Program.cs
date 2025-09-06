Console.WriteLine(LongestCommonPrefix(["flower", "flow", "flight"]));
string LongestCommonPrefix(string[] strs)
{
    var perfix = strs[0];
    for (int i = 1; i < strs.Length; i++)
    {
        var current = strs[i];
        int j = 1;
        while (j < current.Length && j < perfix.Length && current[j] == perfix[j])
            j++;

        perfix = perfix.Substring(0, j);

        if (string.IsNullOrEmpty(perfix))
            break;
    }

    return perfix;
}