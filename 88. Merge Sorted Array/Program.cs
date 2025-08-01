
var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
var nums2 = new int[] { 2, 5, 6 };

Merge(nums1,3, nums2,3);

foreach (var num in nums1)
{
    Console.Write(num + " ");
}

// My solution "Brute Force" O(n+m) * O(log(n+m)))
void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int i = 0, j = nums1.Length - nums2.Length;

    while (j < nums1.Length)
    {
        nums1[j++] = nums2[i++];
    }

    Array.Sort(nums1, 0, nums1.Length);
}

// Optimized solution "Two Pointers" O(n+m) * O(1)
void MergeV2(int[] nums1, int m, int[] nums2, int n)
{
    int i = m - 1, j = n - 1, k = m + n - 1;

    while (j >= 0)
    {
        if (i >= 0 && nums1[i] > nums2[j])
        {
            nums1[k--] = nums1[i--];
        }
        else
        {
            nums1[k--] = nums2[j--];
        }
    }
}