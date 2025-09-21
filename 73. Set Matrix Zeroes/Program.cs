int[][] input =
    [[1, 1, 1], [1, 0, 1], [1, 1, 1]];

SetZeroes(input);

void SetZeroes(int[][] matrix)
{
    HashSet<int> rowsZeros = [];
    HashSet<int> columnsZeros = [];
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[0].Length; j++)
        {
            if (matrix[i][j] == 0)
            {
                rowsZeros.Add(i);
                columnsZeros.Add(j);
            }
        }

    }

    foreach (var row in rowsZeros)
    {
        for (int i = 0; i < matrix[0].Length; i++)
            matrix[row][i] = 0;
    }

    foreach (var column in columnsZeros)
    {
        for (int i = 0; i < matrix.Length; i++)
            matrix[i][column] = 0;
    }
}