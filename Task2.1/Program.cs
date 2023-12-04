using System;
class Program
{
    static void Main()
    {
        Console.Write("Введіть значення: ");
        double number = Convert.ToDouble(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Введене число э від'ємним");
        }
        else if (number > 0)
        {
            Console.WriteLine("Введене число є додатнім");
        }
        else
        {
            Console.WriteLine("Введене число дорівнює 0");
        }
    }
}
