Console.WriteLine(MaxArea([1, 12, 6, 2, 5, 4, 8, 10, 7]));

int MaxArea(int[] height)
{
    int i = 0, j = height.Length - 1;

    int area = 0;
    while (i < j)
    {
        int width = j - i;
        if (height[i] <= height[j])
        {
            area = Math.Max(area, (width * height[i]));
            i++;
        }
        else
        {
            area = Math.Max(area, (width * height[j]));
            j--;
        }
    }

    return area;
}