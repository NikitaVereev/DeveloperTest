using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    public class ZadanieOne
    {
        // Добавлен static
        public static void One()
        {
            Console.Write("Введите число N:");
            int n = int.Parse(Console.ReadLine());
            string result = string.Join(", ", Enumerable.Range(1, n));
            Console.WriteLine(result);
            
        }

    }
    public class ZadanieTwo
    {
        public static void Two()
        {
            Console.Write("Введите нечетное число N:");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Вы ввели четное N.");
                return;
            }
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == n / 2 + 1 && col == n / 2 + 1) Console.Write(" ");
                    else Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
    //Создан класс Programm с методом Main для выбора между заданиями
    class Program
    {
        //Добавлен статический метод Main. Без метода Main программа не будет иметь точки входа и не будет запущена
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание: 1 или 2");
            int choice = int.Parse(Console.ReadLine());
            // Выбор между заданиями
            switch (choice)
            {
                case 1:
                    ZadanieOne.One();
                    break;
                case 2:
                    ZadanieTwo.Two();
                    break;
                default:
                    Console.WriteLine("Некорректный ввод.");
                    break;
            }
            // Добавлен для того, чтобы при выполнении программа не закрывалась сразу
            Console.ReadKey();
        }
    }
}
