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
            Console.WriteLine();

            Random rand = new Random();

            //RandGeneratingSudoku(matrix, rand);
            Console.WriteLine();


            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                    Console.Write(matrix[i, j]);
                Console.WriteLine();
            }

            Console.ReadKey(); 
        }

        private bool isCorrect(int[,] matrix, int line, int column, int num)
        {
            int size = matrix.Length;
            int cellSize = (int)Math.Sqrt(size);
            int cell = (line / cellSize) * cellSize + (column / cellSize);
            int cellLine = (line / cellSize);
            int cellColumn = (column / cellSize);

            for (int i = 0; i < size; ++i)
                if (matrix[i, column] == num) return false;

            for (int j = 0; j < size; ++j)
                if (matrix[line, j] == num) return false;

            for (int i = 0; i < cellSize; ++i)
                for (int j = 0; j < cellSize; ++j)
                    if (matrix[i + cellLine * cellSize, j + cellColumn * cellSize] == num) return false;

            return true;
        }

        private void RandGeneratingSudoku(int[,] matrix, Random rand)
        {
            int size = matrix.Length;
            int line = rand.Next() / size;
            int column = rand.Next() / size;
            int num = rand.Next() / size;
            if (isCorrect(matrix, line, column, num)) matrix[line, column] = num;
        }
    }
}
