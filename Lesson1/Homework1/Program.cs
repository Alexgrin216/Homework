using System;
    namespace CodeName
{
    class Programm
    {
        public static void Main()
        {
            string? name;
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            Console.WriteLine($"Привет,{name}!");
        }
    }
}
