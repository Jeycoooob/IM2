using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int cols = int.Parse(Console.ReadLine());

            List<List<double>> numbers = new List<List<double>>();

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1}");
                List<double> rowList = new List<double>();

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter number{j + 1}: ");
                    double num = double.Parse(Console.ReadLine());
                    rowList.Add(num);
                }

                numbers.Add(rowList);
            }

            Console.WriteLine("\nThe numbers are:");
            double sum = 0;
            int count = 0;

            foreach (var row in numbers)
            {
                foreach (var num in row)
                {
                    Console.Write(num.ToString("0.0") + " ");
                    sum += num;
                    count++;
                }
                Console.WriteLine();
            }

            double average = sum / count;
            Console.WriteLine($"\nSum: {sum:0.0} ; Average: {average:0.0}");

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
