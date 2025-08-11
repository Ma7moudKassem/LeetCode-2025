int[] nums = [0, 0, 2];

Console.WriteLine(HIndex(nums));

int HIndex(int[] citations)
{
    int hIndex = 0;
    
    for (int i = 0; i < citations.Length; i++)
    {
        if (citations[i] >= i + 1)
            hIndex++;
        else 
            hIndex--;
    }

    return hIndex;
}