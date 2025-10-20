Console.WriteLine(FindLexSmallestString("0011", 4, 2));

string FindLexSmallestString(string s, int a, int b)
{
    HashSet<string> uniqueRotations = [];

    string rotated = s;
    for (int i = 0; i < s.Length; i++)
    {
        rotated = Rotate(s, b);
        if (!uniqueRotations.Add(rotated))
            break;
    }

    string smallest = s;
    foreach (string rotate in uniqueRotations)
    {
        for (int i = 0; i < 10; i++)
        {
            string addedToIndices = AddToOddIndices(rotate, a);

            if (string.Compare(addedToIndices, smallest, StringComparison.Ordinal) < 0)
                smallest = addedToIndices;
        }
    }

    return smallest;
}

string AddToOddIndices(string s, int a)
{
    if (s.Length < 1)
        return s;

    var arr = s.ToCharArray();
    for (int i = 1; i < s.Length; i += 2)
    {
        int c = arr[i] - '0';
        arr[i] = (char)(((c + a) % 10) + '0');
    }

    return new string(arr);
}

string Rotate(string s, int b)
{
    b %= s.Length;

    return s[^b..] + s[..^b];
}