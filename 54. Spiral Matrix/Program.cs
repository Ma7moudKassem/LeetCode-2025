
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Security;

int[][] input =
    [[1, 2, 3, 4],
     [5, 6, 7, 8],
     [9, 10, 11, 12]];

SpiralOrder(input);

IList<int> SpiralOrder(int[][] matrix)
{
    int left = 0, top = 0,
        right = matrix[0].Length - 1,
        down = matrix.Length - 1;
    IList<int> result = [];

    while (top <= down && left <= right)
    {
        //From left to right
        for (int i = left; i <= right; i++)
            result.Add(matrix[top][i]);

        top++;

        //From top to down
        for (int i = top; i <= down; i++)
            result.Add(matrix[i][right]);

        right--;

        if (top <= down)
        {
            //from right to left
            for (int i = right; i >= left; i--)
                result.Add(matrix[down][i]);

            down--;
        }
        
        if (left <= right)
        {
            //From down to top
            for (int i = down; i >= top; i--)
                result.Add(matrix[i][left]);

            left++;
        }
    }

    return result;
}