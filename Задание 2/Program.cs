using System;
using System.Collections.Generic;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя первого пользователя!");
            string name1 = Console.ReadLine();
            Console.WriteLine("Введите номер тел первого пользователя!");
            string num1 = Console.ReadLine();
            Console.WriteLine("Введите имя второго пользователя!");
            string name2 = Console.ReadLine();
            Console.WriteLine("Введите номер тел первого пользователя!");
            string num2 = Console.ReadLine();
            Console.WriteLine("Введите имя третьего пользователя!");
            string name3 = Console.ReadLine();
            Console.WriteLine("Введите номер тел первого пользователя!");
            string num3 = Console.ReadLine();

            Dictionary<string, Person> people = new Dictionary<string, Person>();
            people.Add(name1.Remove(1), new Person() { Name = name1 });
            people.Add(name2.Remove(1), new Person() { Name = name2 });
            people.Add(name3.Remove(1), new Person() { Name = name3 });
            Console.WriteLine();

            foreach (KeyValuePair<string, Person> keyValue in people)
            {                
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value.Name}");
            }

            Dictionary<string, string> countries = new Dictionary<string, string>
            {
                [name1] = num1,
                [name2] = num2,
                [name3] = num3
            };
            Console.WriteLine();

            foreach (var pair in countries)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }                
        }
    }
}
