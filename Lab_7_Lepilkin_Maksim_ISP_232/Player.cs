internal class Player()
{
    private int health = 100;
    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            health -= damage;
            Console.WriteLine($"Персонаж получил урон: {damage}. Осталось здоровья: {health}.");
        }
    }
    public int GetHealth()
    {
        return health;
    }
}