Console.WriteLine(GetSum(100, 20));

int GetSum(int a, int b)
{
    while (b != 0)
    {
        int carry = (a & b) << 1;

        a ^= b;
        b = carry;
    }

    return a;
}