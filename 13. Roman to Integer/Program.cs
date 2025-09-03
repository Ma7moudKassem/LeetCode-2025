


Console.WriteLine(RomanToInt("LVIII"));
int RomanToInt(string s)
{
    Dictionary<char, int> maps = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    // M C M X C I V

    int result = 0;
    char c = s[0];
    result += maps[c];
    for (int i = 1; i < s.Length; i++)
    {
        char t = s[i];

        if (maps[t] <= maps[c])
            result += maps[t];
        else
        {
            result -= maps[c];
            result += maps[t] - maps[c];
        }
     
        c = s[i];
    }

    return result;
}

// O(N) Time , O(1) Space