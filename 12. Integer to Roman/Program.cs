using System.Text;

Console.WriteLine(IntToRoman(3749));
string IntToRoman(int num)
{
    int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

    StringBuilder result = new();

    for (int i = 0; i < values.Length && num > 0; i++)
    {
        if (num >= values[i])
        {
            while (num >= values[i])
            {
                num -= values[i];
                result.Append(romans[i]);
            }
        }
    }

    return result.ToString();
}