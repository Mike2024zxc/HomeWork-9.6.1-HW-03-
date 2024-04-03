using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyException myException = new MyException("Собственное исключения");
            DivideByZeroException ex2 = new DivideByZeroException("Знаменатель в операции деления или целого числа Decimal равен нулю.");
            DriveNotFoundException ex3 = new DriveNotFoundException("Диск недоступен или не существует.");
            FileNotFoundException ex4 = new FileNotFoundException("Файл не существует.");
            FormatException ex5 = new FormatException("Значение не находится в соответствующем формате для преобразования из строки методом преобразования, например Parse .");

            Exception[] myArr = new Exception[5] { myException, ex2, ex3, ex4, ex5 };

            for (int i = 0; i < myArr.Length; i++)
            {
                try
                {
                    throw myArr[i];
                }
                catch (Exception exNum)
                {
                    Console.WriteLine(exNum.Message);
                }

            }
            Console.ReadKey();
        }
    }
}
