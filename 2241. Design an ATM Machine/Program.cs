ATM atm = new();

atm.Deposit([0, 0, 1, 2, 1]);
var res = atm.Withdraw(600);

atm.Deposit([0, 1, 0, 1, 1]);
var res1 = atm.Withdraw(600);
var res2 = atm.Withdraw(550);

Console.WriteLine();


public class ATM
{
    private long[] _count;
    private int[] _banknotes;
    public ATM()
    {
        _count = new long[5];
        _banknotes = [20, 50, 100, 200, 500];
    }

    public void Deposit(int[] banknotesCount)
    {
        for (int i = 0; i < banknotesCount.Length; i++)
            _count[i] += banknotesCount[i];
    }

    public int[] Withdraw(int amount)
    {
        long total = 0;
        for (int i = 0; i < 5; i++)
            total += _count[i] * _banknotes[i];

        if (total < amount)
            return [-1];

        int[] res = new int[5];
        int remaining = amount;

        for (int i = 4; i >= 0; i--)
        {
            if (remaining <= 0) break;

            int canUse = (int)Math.Min(_count[i], remaining / _banknotes[i]);
            res[i] = canUse;

            remaining -= canUse * _banknotes[i];
        }

        if (remaining != 0)
            return [-1];

        for (int i = 0; i < 5; i++)
            _count[i] -= res[i];

        return res;
    }
}