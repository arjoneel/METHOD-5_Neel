using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_5
{
    internal class Program
    {
        static int[] array;

        static void Main(string[] args)
        {
            int size = -1;
            Console.WriteLine("Input: ");

            try
            {
                size = Convert.ToInt32(Console.ReadLine());

                if (size >= 5 && size <= 15)
                {
                    PopulateArray(size);
                    SummationOfArray(array);
                }
                else
                    throw new Exception("Input number is not in LIMIT.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} Input number between 5 and 15.");
            }

            Console.ReadLine();
        }

        static void PopulateArray(int size)
        {
            Console.WriteLine();
            Console.WriteLine("Array Elements are: ");

            array = new int[size];

            Random rnd = new Random();

            for (int i = 0; i < array.Count(); i++)
            {
                int element = rnd.Next(10, 51);

                array[i] = element;

                Console.WriteLine(element);
            }
        }

        static void SummationOfArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Count(); i++)
            {

                sum += array[i];

            }

            Console.WriteLine($"\n\nSum of Array is: {sum}");

        }
    }
}
