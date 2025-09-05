
Console.WriteLine(LengthOfLastWord("  "));

int LengthOfLastWord(string s)
{
    if (s.Length <= 1)
        return s.Length == 0 ? 0 : s[0] != ' ' ? 1 : 0;

    int pointer = s.Length - 1, l = 0;
    while (pointer >= 0)
    {
        if (s[pointer] == ' ' && l > 0)
            return l;

        if (s[pointer] != ' ')
            l++;

        pointer--;
    }

    return l;
}