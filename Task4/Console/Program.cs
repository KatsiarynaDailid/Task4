using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4_2;
using Task4_1;

namespace ConsoleForTask4
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Реализовать класс Point с двумя свойствами: X и Y.Переопределить для него Equals() и ToString()


            Point point = new Point(1, 2);
            Console.WriteLine(point);

            //2.Напишите класс для расчета ряда чисел Фибоначчи и факториала. Выберите правильный тип класса.


            Console.WriteLine("Enter the number for calculating factorial ");
            int n = Int32.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(MathOper.FactTree(n));
            }
            catch(Exception ex) {

                Console.WriteLine("There is no way to calculate the factorial from negative number.");
                
            }

            Console.WriteLine("Enter the number for calculating the Fibonacci row: ");
            int n1 = Int32.Parse(Console.ReadLine());
            try
            {
               
            Console.WriteLine(MathOper.CountFibonacci(n1));
            }
            catch (Exception ex)
            {

                Console.WriteLine("There is no way to calculate the factorial from negative number.");

            }
            //3.Напишите класс, который умеет хранить информацию об общем количестве созданных экземпляров своего типа.
            Console.WriteLine("uhu");
            Console.ReadLine();

        }
    }
}
