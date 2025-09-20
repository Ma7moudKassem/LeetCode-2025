int[][] m =
    [[1, 2, 3],
     [4, 5, 6],
     [7, 8, 9]];

Rotate(ref m);

void Rotate(ref int[][] matrix)
{
    int n = matrix.Length;

    for (int i = 0; i < n; i++)
    {
        for (int j = i; j < n; j++)
            (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
    }

    for (int i = 0; i < matrix.Length; i++)
        Array.Reverse(matrix[i]);
}