using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_23
{
    //Разработать асинхронный метод для вычисления факториала числа.
    //В методе Main выполнить проверку работы метода.



    class Program
    {
        static void Factorial()
        {
            //ввод значения
            Console.WriteLine("Введите число: ");
            int f = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i<f; i++)
            {
                result *= i;
            }
            Thread.Sleep(100);
            Console.WriteLine($"Факториал равен {result}");
        }
        //Асинхронный метод
        static async void FactorialAsync()
        {
            Console.WriteLine("Начало метода FactorialAsync"); 
            await Task.Run(() => Factorial());                
            Console.WriteLine("Конец метода FactorialAsync");
        }

        static void Main(string[] args)
        {
            FactorialAsync();   

            
            for (int i = 0; i < 19; i++)
            {
                 int c = i;
                Console.WriteLine($"Счет!{c}");
            }

            Console.Read();
        }
    }
}
