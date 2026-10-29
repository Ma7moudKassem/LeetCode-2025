

int MinimumTimeToInitialState(string word, int k)
{
    int n = word.Length;
    for (int t = 1; t * k < n; t++)
    {
        int removed = t * k;
        int remaing = n - removed;
      
        if (word.Substring(removed) == word.Substring(0, remaing))
            return t;
    }


    return (n + k - 1) / k;
}