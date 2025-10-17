internal class BankAccount
{
    private decimal balance = 0m;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Пополнение: {amount}. Текущий баланс: {balance}");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Снятие: {amount}. Остаток: {balance}");
        }
        else
        {
            Console.WriteLine("Недостаточно средств!");
        }
    }
}