using System.Collections;
using System.Text;

namespace Asd_laba_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.OutputEncoding = Encoding.UTF8;

            HashTable table = new HashTable(11);

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Додати співробітника");
                Console.WriteLine("2. Знайти співробітника");
                Console.WriteLine("3. Видалити співробітника");
                Console.WriteLine("4. Вивести хеш-таблицю");
                Console.WriteLine("0. Вихід");
                Console.Write("Ваш вибір: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Введіть ПІБ: ");
                        string name = Console.ReadLine();
                        table.Insert(name);
                        break;
                    case "2":
                        Console.Write("Введіть ПІБ для пошуку: ");
                        string searchName = Console.ReadLine();
                        bool found = table.Search(searchName);
                        Console.WriteLine(found ? "Знайдено!" : "Не знайдено.");
                        break;
                    case "3":
                        Console.Write("Введіть ПІБ для видалення: ");
                        string deleteName = Console.ReadLine();
                        bool removed = table.Delete(deleteName);
                        Console.WriteLine(removed ? "Видалено!" : "Не знайдено.");
                        break;
                    case "4":
                        table.Print();
                        break;
                    case "0":
                        return;
                }
            }
        }
    }
}