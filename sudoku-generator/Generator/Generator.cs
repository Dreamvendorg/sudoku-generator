using System;

public class Generator
{
    Random random = new Random();
 	public Generator()
	{

    }

    public bool isCorrect(int[,] matrix, int line, int column, int num)
    {
        int size = (int)Math.Sqrt(matrix.Length);
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

    public void RandGeneratingSudoku(int[,] matrix)
    {
        int size = (int)Math.Sqrt(matrix.Length);
        int line = random.Next() % size;
        int column = random.Next() % size;
        int num = (random.Next() % size) + 1;
        if (isCorrect(matrix, line, column, num)) matrix[line, column] = num;
    }
}
