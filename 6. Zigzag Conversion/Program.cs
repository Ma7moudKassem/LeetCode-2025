
using System.Text;

Console.WriteLine(Convert("PAYPALISHIRING", 4));
string Convert(string s, int numRows)
{
    if (numRows >= s.Length || numRows < 2)
        return s;

    StringBuilder[] terms = new StringBuilder[numRows];

    //initialize
    for (int i = 0; i < numRows; i++)
        terms[i] = new StringBuilder();

    int j = 0, dir = 1;
    foreach (var c in s)
    {
        terms[j].Append(c);

        if (j == 0) dir = 1;
        else if (j == numRows - 1) dir = -1;

        j += dir;
    }

    StringBuilder sb = new();
    foreach (var term in terms)
        sb.Append(term);

    return sb.ToString();
}