using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int trueSize = 3;
            int size = trueSize * trueSize;

            int[,] matrix = new int[size, size];


            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                    Console.Write(matrix[i,j]);
                Console.WriteLine();
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey(); 
        }
    }
}
