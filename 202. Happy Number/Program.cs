
Console.WriteLine(IsHappy(7));

bool IsHappy(int n)
{
    string target = n.ToString();
    HashSet<int> visited = [];
    while (true)
    {
        int happy = 0;
        foreach (var c in target)
        {
            int digit = c - '0';

            happy = digit * digit;
        }

        if (happy == 1)
            return true;

        if (visited.Contains(happy))
            return false;

        visited.Add(happy);

        target = happy.ToString();
    }
}