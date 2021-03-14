using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ого! Привет!");
            Console.WriteLine("Давай длину ребра куба. Я дам объем куба и площадь его боковой поверхности -\\_(._.)_/-");
            Console.Write("Длина ребра = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nОбъём =\t\t {a * a * a}\nПлощадь =\t {6*a*a}");

            Console.WriteLine("\nНажмите любую клавишу для выхода.");//чтобы приложение сразу не закрывалось
            Console.ReadKey();
        }
    }
}
