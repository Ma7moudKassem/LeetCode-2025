Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));

bool IsPalindrome(string s)
{
    int i = 0, j = s.Length - 1;
    while (i <= j)
    {
        while (i < j && !char.IsLetterOrDigit(s[j]))
            j--;

        while (i < j && !char.IsLetterOrDigit(s[i]))
            i++;

        if (char.ToLowerInvariant(s[i++]) != char.ToLowerInvariant(s[j--]))
            return false;
    }

    return true;
}