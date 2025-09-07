
using System.Text;

Console.WriteLine(ReverseWords("  hello world  "));
string ReverseWords(string s)
{
    if (string.IsNullOrWhiteSpace(s) || string.IsNullOrEmpty(s))
        return "";

    int j = s.Length - 1;
    StringBuilder stringBuilder = new();
    while (j >= 0)
    {
        while (j >= 0 && s[j] == ' ')
            j--;

        if (j < 0) break;

        int i = j;

        while (i >= 0 && s[i] != ' ')
            i--;

        var subStr = s.AsSpan(i + 1, j - i);

        stringBuilder.Append(subStr);

        stringBuilder.Append(' ');
        j = i;
    }

    string result = stringBuilder.ToString();
    return result.Length > 0
        ? result[..^1]
        : result;
}