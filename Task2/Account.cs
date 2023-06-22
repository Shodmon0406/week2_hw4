class Account
{
    int _number;
    decimal _balance;
    public Account(int number)
    {
        _number = number;
    }
    public Account(int number, decimal balance)
    {
        _number = number;
        _balance = balance;
    }
    public int Number { get; }
    public decimal Balance { get; }
    public string ToString()
    {
        return $"Account [number={_number}, balance={_balance}]";
    }
    public void Credit(decimal amount)
    {
        _balance += amount;
    }
    public void Debit(decimal amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
        }
        else
        {
            System.Console.WriteLine("Amount exceeded");
        }
    }
    public void TransferTo(decimal amount, Account another)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
            another._balance += amount;
        }
        else
        {
            System.Console.WriteLine("Amount exceeded");
        }
    }
}