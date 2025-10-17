
var c = MaxSatisfied([4, 10, 10], [1, 1, 0], 2);
//var c = MaxSatisfied([1, 0, 1, 2, 1, 1, 7, 5], [0, 1, 0, 1, 0, 1, 0, 1], 3);

Console.WriteLine();
int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
{
    int alwaysSatisfied = 0;
    for (int i = 0; i < customers.Length; i++)
    {
        if (grumpy[i] == 1)
            continue;

        alwaysSatisfied += customers[i];
    }

    int extra = 0, extraAfterMinutes = 0;
    for (int i = 0; i < customers.Length; i++)
    {
        if (grumpy[i] == 1)
            extra += customers[i];

        if (i >= minutes && grumpy[i - minutes] == 1)
            extra -= customers[i - minutes];

        extraAfterMinutes = Math.Max(extraAfterMinutes, extra);
    }

    return alwaysSatisfied + extraAfterMinutes;
}