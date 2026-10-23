
var c = FindRepeatedDnaSequences("TTTGTTTTTTTTTTTTTTTGTTTTTCTGCGCGGTTTTTTTCTGCGCGGTTTTTTTTTTTTTTTATTTTTTGTTT");

Console.WriteLine();
IList<string> FindRepeatedDnaSequences(string s)
{
    int n = s.Length;

    HashSet<string> seen = [];
    HashSet<string> res = [];

    for (int i = 0; i + 10 <= n; i++)
    {
        string window = s.Substring(i, 10);

        if (string.IsNullOrWhiteSpace(window))
            continue;

        if (!seen.Add(window))
            res.Add(window);
    }

    return [..res];
}