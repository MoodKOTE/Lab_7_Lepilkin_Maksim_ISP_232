class BankAccount1
{
    public string? accountNumber;
    private decimal balance = 0m;

    public void Deposit_1(decimal amount)
    {
        if (this.balance <= 0)
        {
            this.balance += amount;
            Console.WriteLine($"Пополнение: {amount}. Текущий баланс: {this.balance}");
        }
    }
    public void Withdraw1(decimal amount)
    {
        if (amount > 0 && amount <= this.balance)
        {
            this.balance -= amount;
            Console.WriteLine($"Снятие: {amount}. Остаток: {this.balance}");
        }
        else
        {
            Console.WriteLine("Недостаточно средств!");
        }
    }
    public void PrintBalance()
    {
        Console.WriteLine($"Текущий баланс: {this.balance}");
    }
}