class Dice
{
    static Random random = new Random();
    public int _sides;
    public Dice(int sides = 6)
    {
        this._sides = sides;
    }
    public int Roll()
    {
        return random.Next(1, _sides + 1);
    }
}