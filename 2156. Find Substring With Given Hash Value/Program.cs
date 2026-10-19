Console.WriteLine($"SubStrHash: {SubStrHash("leetcode", 7, 20, 2, 0)}");

string SubStrHash(string s, int power, int modulo, int k, int hashValue)
{
    int n = s.Length;

    long[] hashes = new long[n];

    for (int i = 0; i < n; i++)
    {
        int val = s[i] - 'a' + 1;

        long currentPower = (long)MathF.Pow(power, val);

        long hash = (val * currentPower) % modulo;

        hashes[i] = hash;
    }

    long window = 0;
    for (int i = 0; i < k; i++)
        window += hashes[i];


    int j = 0;
    for (int i = k; i + k < n; i++)
    {
        if (window == hashValue)
            return s.Substring(j, k);

        window -= hashes[i];
        window += hashes[j];

        j++;
    }

    return s;
}

int Hash(string s, int power, int modulo)
{
    int n = s.Length;

    long hashWithoutMode = 0;
    long currentPower = 1;

    for (int i = 0; i < n; i++)
    {
        int alphIndex = (s[i] - 'a') + 1;

        hashWithoutMode = (hashWithoutMode + (alphIndex * currentPower)) % modulo;

        currentPower = (currentPower * power) % modulo;
    }

    return (int)(hashWithoutMode);
}