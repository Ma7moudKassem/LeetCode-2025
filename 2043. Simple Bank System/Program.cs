public class Bank
{
    private long[] _balance;
    public Bank(long[] balance)
    {
        _balance = balance;
    }

    public bool Transfer(int account1, int account2, long money)
    {
        if (!IsAccountExist(account1) || !IsAccountExist(account2) || _balance[account1 - 1] < money)
            return false;

        _balance[account1 - 1] -= money;
        _balance[account2 - 1] += money;

        return true;
    }

    public bool Deposit(int account, long money)
    {
        if (!IsAccountExist(account))
            return false;

        _balance[account - 1] += money;
        return true;
    }

    public bool Withdraw(int account, long money)
    {
        if (!IsAccountExist(account) || _balance[account - 1] < money)
            return false;

        _balance[account - 1] -= money;
        return true;
    }

    private bool IsAccountExist(int account)
    {
        int length = _balance.Length;

        if (account > 0 && account <= length)
            return true;

        return false;
    }
}