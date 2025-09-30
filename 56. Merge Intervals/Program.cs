int[][] arr = [[4, 7], [1, 4]];

Merge(arr);

//O(NLog(N))
int[][] Merge(int[][] intervals)
{
    if (!IsSorted(intervals))
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

    List<int[]> res = [[intervals[0][0], intervals[0][1]]];
    int n = intervals.Length;
    for (int i = 0; i < n; i++)
    {
        int start = intervals[i][0],
            end = intervals[i][1];

        var last = res.Last();

        if (last[1] >= start)
            last[1] = Math.Max(last[1], end);
        else
            res.Add([start, end]);
    }

    return [.. res];
}
bool IsSorted(int[][] intervals)
{
    for (int i = 1; i < intervals.Length; i++)
    {
        if (intervals[i][0] < intervals[i - 1][0])
            return false;
    }
    return true;
}

// O(N^2) Time
//int[][] Merge(int[][] intervals)
//{
//    Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

//    int[][] result = [];

//    for (int i = 0; i < intervals.Length; i++)
//    {
//        int start = intervals[i][0], end = intervals[i][1];

//        if (result.Length > 0 && result[^1][1] >= end)
//            continue;

//        for (int j = i; j < intervals.Length; j++)
//        {
//            if (intervals[j][0] <= end)
//                end = Math.Max(end, intervals[j][1]);
//        }

//        result = [..result, [start, end]];
//    }

//    return result;
//}