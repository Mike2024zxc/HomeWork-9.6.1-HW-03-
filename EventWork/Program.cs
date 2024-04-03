using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExceptionWork;

namespace EventWork
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            list.Add("Пушкин");
            list.Add("Лермонтов");
            list.Add("Гоголь");
            list.Add("Толстой");
            list.Add("Достоевский");
            Console.WriteLine("Несортированный список:");

            foreach (string str in list)
                Console.WriteLine(str);
            Console.WriteLine();

            NumberReader numberReader = new NumberReader();
            numberReader.NumberEvent += ShowNumber;

            while (true)
            {
                try
                {
                    numberReader.Read();
                }

                catch (FormatException)
                {
                    Console.WriteLine("Некорректное значение");


                }
                catch (MyException myException)
                {
                    Console.WriteLine(myException.Message);
                }

            }

             void ShowNumber(int num)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Отсортированный список: от А до Я");
                        list.Sort();
                        foreach (string str in list)
                            Console.WriteLine(str); ; break;
                    case 2:
                        Console.WriteLine("Отсортированный список: от Я до А");
                        list.Sort();
                        list.Reverse();
                        foreach (string str in list)
                            Console.WriteLine(str); ; break;
                }
            }

        }
    }
}
