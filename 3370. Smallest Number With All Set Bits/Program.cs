var v = SmallestNumber(5);

Console.WriteLine();

int SmallestNumber(int n)
{
    int res = 1;
    while (res < n)
        res = (res << 1) | 1;

    return res;
}
