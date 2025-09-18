char[][] boards =
[['.', '.', '4', '.', '.', '.', '6', '3', '.'],
 ['.', '3', '.', '.', '1', '.', '.', '.', '.'],
 ['5', '.', '.', '.', '.', '.', '.', '9', '.'],
 ['.', '.', '.', '5', '6', '.', '.', '.', '.'],
 ['4', '.', '3', '.', '.', '.', '.', '.', '1'],
 ['.', '.', '.', '7', '.', '.', '.', '.', '.'],
 ['.', '.', '.', '5', '.', '.', '1', '.', '.'],
 ['.', '2', '.', '.', '.', '.', '.', '.', '.'],
 ['.', '.', '.', '.', '.', '.', '.', '.', '.']];

Console.WriteLine(IsValidSudoku(boards));

bool IsValidSudoku(char[][] board)
{
    HashSet<(char, int)> boxes = [];
    for (int i = 0; i < 9; i++)
    {
        HashSet<char> rows = [];
        HashSet<char> columns = [];
        for (int j = 0; j < 9; j++)
        {
            char row = board[i][j];
            if (row != '.')
            {
                if (row < '1' || row > '9' || !rows.Add(row))
                    return false;

                int boxId = (i / 3) * 3 + (j / 3);
                if (!boxes.Add((row, boxId)))
                    return false;
            }

            char column = board[j][i];
            if (column != '.')
            {
                if (column < '1' || column > '9' || !columns.Add(column))
                    return false;
            }
        }
    }

    return true;
}