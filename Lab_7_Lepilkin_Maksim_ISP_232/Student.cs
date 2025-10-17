class Student
{
    public string? name;
    public int age;
    public string? group;

    public Student()
    {
        Console.WriteLine("Создание объекта Студента");
        name = "Неиз";
        age = 18;
        group = "Неиз";
    }
    public Student(string name)
    {
        this.name = name;
        age = 18;
        group = "Неиз";
    }
    public Student(string name, int age) 
    {
        this.name = name;
        this.age = age;
        group = "Неиз";
    }
    public Student(string name, int age, string group)
    {
        this.name = name;
        this.age = age;
        this.group = group;

    }


    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Group: {group}");
    }
    public bool IsAdult()
    {
        return age >= 18;
    }
}
