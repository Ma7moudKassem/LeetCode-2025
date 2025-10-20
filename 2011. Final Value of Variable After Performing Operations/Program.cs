int FinalValueAfterOperations(string[] operations)
{
    int x = 0;
    foreach (string operation in operations)
        x += operation[1] == '+' ? 1 : -1;

    return x;
}