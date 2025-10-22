
using System.Text;

Console.WriteLine(LargestMerge("abcabc", "abdcaba"));
string LargestMerge(string word1, string word2)
{
    StringBuilder result = new();

    int i = 0, j = 0;

    while (i < word1.Length && j < word2.Length)
    {
        if (IsLarger(word1, i , word2, j))
        {
            result.Append(word1[i]);
            i++;
        }
        else
        {
            result.Append(word2[j]);
            j++;
        }
    }

    result.Append(word1.AsSpan(i));
    result.Append(word2.AsSpan(j));

    return result.ToString();
}

bool IsLarger(string a , int i, string b, int j)
{
    while (i < a.Length && j < b.Length)
    {
        if (a[i] != b[j])
            return a[i] > b[j];

        i++;
        j++;
    }

    return i < a.Length;
}