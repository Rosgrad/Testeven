using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testeven
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            int b;
            Console.WriteLine("Есть два варианта решения: ");
            Console.WriteLine("Выберите вариант 1 или 2: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b==1)
            Var1();
            else if (b==2)
             Var2();
            else if (b>2)
           Console.WriteLine("Нет такого варината решения!!! ");
        }

        static void Var1()
        {
            int a;
            Console.WriteLine("введите число: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("четное число");
            }
            else
            {
                Console.WriteLine("нечетное");
            }
            Console.ReadKey();
        }
        static void Var2()
        {
            int a;
            Console.WriteLine("введите число: ");
            a = int.Parse(Console.ReadLine());
            int temp = a % 2;
            bool result = temp == 0;
            if (result)
            {
                Console.WriteLine("четное число");
            }
            else
            {
                Console.WriteLine("нечетное");
            }
            Console.ReadKey();
        }
         
    }
   
    }

 
