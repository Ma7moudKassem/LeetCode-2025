int[] nums = [2, 2, 1, 1, 1, 2, 2];

Console.WriteLine(MajorityElement(nums));

//Alternative solution -> Time complexity O(n) and Space complexity O(1)
//Boyer-Moore Voting Algorithm
int MajorityElement(int[] nums)
{
    int count = 0, candidate = 0;

    foreach (int num in nums)
    {
        if (count == 0)
            candidate = num;

        _ = candidate == num 
            ? count++ 
            : count--;   
    }

    return candidate;
}


//Brute force solution -> Space complexity O(n)
//int MajorityElement(int[] nums)
//{
//    if (nums.Length == 0)
//        return 0;

//    var map = new Dictionary<int, int>();

//    foreach (var num in nums)
//    { 
//        if (map.ContainsKey(num))
//            map[num]++;
//        else map.Add(num, 1);
//    }

//    int dupNum = 0;
//    int result = 0;
//    foreach (var item in map)
//    {
//        if (item.Value > 0 && item.Value % 2 >= 0)
//        {
//            if (item.Value > dupNum)
//            { 
//                dupNum = item.Value;
//                result = item.Key;
//            }
//        }
//    }

//    return result;
//}