using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        double A = 0, B = 0;

        do
        {
            Console.WriteLine("Выберите пункт меню:");
            Console.WriteLine("1. Ввести A");
            Console.WriteLine("2. Ввести B");
            Console.WriteLine("3. Сложить (+)");
            Console.WriteLine("4. Вычесть (-)");
            Console.WriteLine("5. Умножить (*)");
            Console.WriteLine("6. Разделить (/)");
            Console.WriteLine("0. Выход");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введите A: ");
                    A = double.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Введите B: ");
                    B = double.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine($"Результат: {A + B}");
                    break;
                case 4:
                    Console.WriteLine($"Результат: {A - B}");
                    break;

            }
        } while (choice != 0);
    }
}