

int[] gas = [1, 2, 3, 4, 5], cost = [3, 4, 5, 1, 2];

Console.WriteLine(CanCompleteCircuit(gas, cost));

int CanCompleteCircuit(int[] gas, int[] cost)
{
    int totalGas = 0, totalCost = 0, tank = 0,
    start = 0;
    for (int i = 0; i < gas.Length; i++)
    {
        totalGas += gas[i];
        totalCost += cost[i];

        tank += gas[i] - cost[i];

        if (tank < 0)
        {
            start = i + 1;
            tank = 0;
        }
    }

    return totalGas < totalCost ? -1 : start;
}