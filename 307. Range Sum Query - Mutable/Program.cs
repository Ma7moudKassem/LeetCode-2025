var arr = new NumArray([1, 3, 5]);

var x = arr.SumRange(0, 2); //9

arr.Update(1, 2); //1,2,5

var y = arr.SumRange(0, 2);//8
Console.WriteLine();

public class NumArray
{
    private int[] _nums;
    private int[] _bit;
    private int _n;
    public NumArray(int[] nums)
    {
        _nums = nums;
        _n = nums.Length;

        _bit = new int[_n + 1];

        for (int i = 0; i < nums.Length; i++)
            AddToBIT(i + 1, nums[i]);
    }

    void AddToBIT(int index, int value)
    {
        while (index <= _n)
        {
            _bit[index] += value;

            index += index & -index;
        }
    }
    public void Update(int index, int val)
    {
        int diff = val - _nums[index];
        if (diff == 0)
            return;

        _nums[index] = val;

        AddToBIT(index + 1, diff);
    }

    public int SumRange(int left, int right) =>
        PrefixSum(right + 1) - PrefixSum(left);

    int PrefixSum(int index)
    {
        int sum = 0;
        while (index > 0)
        {
            sum += _bit[index];

            index -= index & -index;
        }

        return sum;
    }
}