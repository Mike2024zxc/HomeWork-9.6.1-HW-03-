using System;
using System.Collections.Generic;
using System.Text;
using ExceptionWork;

namespace EventWork
{
    class NumberReader
    {
        public delegate void NumberDelegate(int num);
        public event NumberDelegate NumberEvent;

        public void Read()
        {

            Console.WriteLine();
            Console.WriteLine("Введите значение: 1 или 2");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 10)
            { 
                throw new MyException("Собственное исключение num = 10"); 
            }
            else if(num != 1 && num != 2)
            {
                throw new FormatException();
            }
           
            NumberEnter(num);
        }

        protected virtual void NumberEnter(int num)
        {
            NumberEvent?.Invoke(num);

        }
    }
}
