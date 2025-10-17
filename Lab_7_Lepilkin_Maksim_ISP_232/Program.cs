using Microsoft.VisualBasic;
using System.Net;

namespace Lab_7_Lepilkin_Maksim_ISP_232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student denis = new Student();
            //denis.name = "Denis";
            //denis.age = 18;
            //denis.group = "ISP-231";
            //denis.PrintInfo();
            //Console.WriteLine($"Студент {denis.name} совершеннолетний - {denis.IsAdult()}");

            //Student max = new Student();
            //max.name = "Max";
            //max.age = 18;
            //max.group = "ISP-232";
            //max.PrintInfo();

            //Student anton = new();
            //anton.PrintInfo();

            //Car myCar = new Car();
            //myCar.model = "BMW";
            //Console.WriteLine($"Модель: {myCar.model}");
            //myCar.Accelerate(20);

            //Player player = new Player();
            //player.TakeDamage(34);
            //Console.WriteLine(player.GetHealth());

            //Television tv = new Television();
            //tv.SetVolume(50);
            //tv.SetVolume(150);

            //BankAccount bankaccount = new BankAccount();
            //bankaccount.Deposit(50);
            //bankaccount.Withdraw(23);

            //Person bob = new(68);
            //bob.CheckAge(); 
            //Person tom = new(37);
            //tom.CheckAge(); 
            //Console.WriteLine(Person.retirementAge); 
            //Person.retirementAge = 67;

            //Console.Write("Введите количество карт для выбора: ");
            //string? line = Console.ReadLine();

            //if (int.TryParse(line, out int numberOfCards))
            //{
            //    foreach (string card in CardPicker.PickSomeCards(numberOfCards))
            //    {
            //        Console.WriteLine(card);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Введите корректное число.");
            //}

            // задание 1
            //Book book = new Book();
            //book.title = "Онегин";
            //book.author = "Пушкин";
            //book.year = 1833;
            //book.isAvailable = true;
            //book.PrintInfo();

            //Book book1 = new Book();
            //book1.PrintInfo();

            // задание 2
            //BankAccount1 account = new BankAccount1();
            //account.Deposit_1(1000);
            //account.Withdraw1(500);
            //account.PrintBalance();

            // задание 3
            //Car_DZ_ car = new Car_DZ_("BMW i8", 120);
            //car.Accelerate1(120);
            //car.Brake();

            // задание 4
            //Dice dice = new Dice();
            //Dice dice1 = new Dice(12);
            //Console.WriteLine($"{dice._sides}-гранный кубик: {dice.Roll()},{dice.Roll()},{dice.Roll()}");
            //Console.WriteLine($"{dice1._sides}-гранный кубик: {dice1.Roll()},{dice1.Roll()},{dice1.Roll()}");

            // задание 5
            Character warrior = new Character();
            Character archer = new Character();
            Character mage = new Character();
            Console.WriteLine($"Класс Воин - Здоровье: {warrior.Health = 100} | Мана: {warrior.Mana = 20}");
            warrior.Attack();
            Console.WriteLine($"Класс Лучник - Здоровье: {archer.Health = 75} | Мана: {archer.Mana = 50}");
            archer.Attack();
            Console.WriteLine($"Класс Маг - Здоровье: {mage.Health = 50} | Мана: {mage.Mana = 100}");
            mage.Attack();

        }
    }
    
}    
