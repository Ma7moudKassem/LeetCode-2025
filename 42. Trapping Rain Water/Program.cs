int[] heights = [0,1,0,2,1,0,1,3,2,1,2,1];



Console.WriteLine(Trap(heights));

//Using dynamic programming
int Trap(int[] height)
{
    int water = 0;
    int n = height.Length;

    int[] maxRight = new int[n];
    int[] maxLeft = new int[n];

    maxLeft[0] = height[0];
    for (int i = 1; i < n; i++)
        maxLeft[i] = Math.Max(maxLeft[i - 1], height[i]);

    maxRight[n - 1] = height[n - 1];
    for (int i = n - 2; i >= 0; i--)
        maxRight[i] = Math.Max(maxRight[i + 1], height[i]);

    for (int i = 0; i < n; i++)
        water += Math.Min(maxLeft[i], maxRight[i]) - height[i];

    return water;
}

//Using two pointers
//int Trap(int[] height)
//{
//    int water = 0;
//    int left = 0, right = height.Length - 1;

//    int maxLeft = 0, maxRight = 0;

//    while (left < right)
//    {
//        if (height[left] < height[right])
//        {
//            if (height[left] >= maxLeft)
//                maxLeft = height[left];
//            else
//                water += maxLeft - height[left];

//            left++;
//        }
//        else
//        {
//            if (height[right] >= maxRight)
//            {
//                maxRight = height[right];
//            }
//            else
//                water += maxRight - height[right];

//            right--;
//        }
//    }

//    return water;
//}