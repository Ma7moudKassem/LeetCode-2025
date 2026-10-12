
string s = "abcabcd";

Console.WriteLine(string.Join(" ", PrefixFunction(s)));

int[] PrefixFunction(string s)
{
    int n = s.Length;
    int[] pi = new int[n];

    int i = 0, j = 1;

    while(j < n)
    {
        if (s[i] == s[j])
        {
            pi[j] = i + 1;
            i++; j++;
        }
        else 
        {
            if (i == 0)
            {
                pi[j] = 0;
                j++;
            }
            else
            {
                i = pi[i - 1];
            }
        }
    }
    return pi;
}

string text = "abxababc";
string pattern = "ababi";

Console.WriteLine($"Is pattern found in text? {SearchSubstring(text, pattern)}");
bool SearchSubstring(string text, string pattern)
{
    int[] lps = PrefixFunction(text);

    int i = 0, j = 0;

    while(i < text.Length)
    {

        if (text[i] == pattern[j])
        {
            i++;j++;
            if (j == pattern.Length)
            {
                return true;

                j = lps[j - 1];
            }
        }
        else //mismatch
        {
            if(j != 0)
            {
                j = lps[j - 1];
            }
            else
            {
                i++;
            }
        }
    }

    return false;
}

