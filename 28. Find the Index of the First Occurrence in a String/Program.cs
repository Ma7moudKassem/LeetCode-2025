Console.WriteLine(StrStr("a", "a"));

int StrStr(string haystack, string needle)
{
    if (needle.Length > haystack.Length)
        return -1;

    int size = needle.Length;
    for (int i = 0; i < haystack.Length; i++)
    {
        if (haystack.Length - i >= size)
        {
            string sub = haystack.Substring(i, size);
            if (sub == needle)
                return i;
        }
    }

    return -1;
}