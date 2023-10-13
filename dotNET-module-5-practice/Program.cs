using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_5_practice
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Вызываем метод, который может сгенерировать исключение
                CallMethodWithException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }

        // Метод, который генерирует исключение
        static void MethodThatThrowsException()
        {
            throw new InvalidOperationException("Исключение внутри MethodThatThrowsException");
        }

        // Метод, который вызывает MethodThatThrowsException и "поднимает" исключение
        static void CallMethodWithException()
        {
            try
            {
                MethodThatThrowsException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка в CallMethodWithException: " + ex.Message);
                // Поднимаем исключение в вызывающий метод
                throw;
            }
        }
    }

}
