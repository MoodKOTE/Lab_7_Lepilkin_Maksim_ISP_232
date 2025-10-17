internal class Television
{
    private int volume = 100;
    public void SetVolume(int newVolume)
    {
        if (newVolume >= 0 && newVolume <= 100)
        {
            volume = newVolume;
            Console.WriteLine($"Громкость изменена: {volume}");
        }
        else
        {
            Console.WriteLine("Ошибка! Громкость должна быть от 0 до 100.");
        }
    }
}
