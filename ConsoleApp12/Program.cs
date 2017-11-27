
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        public static void Task1()
        {
            int the_result;
            int second_argument;
            int first_argument;
            try
            {
                Console.Write("Enter the first argument->");
                first_argument = int.Parse(Console.ReadLine());
                Console.Write("Enter the second argument->");
                second_argument = int.Parse(Console.ReadLine());
                the_result = first_argument / second_argument;

            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
        public static void Task2()
        {
            int size_of_massive = 5;
            int counter = 0;
            int[] massive = new int[size_of_massive];
            try
            {
                for (int i = 0; i <= massive.Length; i++)
                {
                    Console.WriteLine(massive[i] = counter++);
                }
            }
            catch (IndexOutOfRangeException expection)
            {
                Console.Write(expection);
                throw;
            }
        }
    }
}


