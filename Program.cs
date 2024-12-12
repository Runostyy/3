using System;

class Program
{
    static void Main()
    {
        // Оголошуємо лямбда-вираз з використанням делегату Predicate
        Predicate<int> isPositive = x => x > 0;

        // Введення числа з консолі
        Console.WriteLine("Введіть число:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Викликаємо лямбда-вираз та виводимо результат
        if (isPositive(number))
        {
            Console.WriteLine($"{number} є додатнім числом.");
        }
        else
        {
            Console.WriteLine($"{number} не є додатнім числом.");
        }
    }
}
