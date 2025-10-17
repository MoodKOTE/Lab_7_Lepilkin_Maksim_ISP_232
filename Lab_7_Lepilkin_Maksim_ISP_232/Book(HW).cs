class Book
{
    public string? title;
    public string? author;
    public int year;
    public bool isAvailable;

    public Book()
    {
        title = "Неизвестно";
        author = "Неизвестно";
        year = 0;
        isAvailable = false;
    }

    public Book(string title, string author, int year, bool isAvailable)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.isAvailable = isAvailable;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Название: {title}, Автор: {author}, Год: {year}, Доступна: {isAvailable}");
    }

}