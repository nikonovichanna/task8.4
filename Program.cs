int[, ,] GetMatrix(int x, int y, int z)
{
    int[, ,] matrix = new int[x, y, z];
    Random rand = new Random();

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
            matrix[i, j, k] = rand.Next(1, 9);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[, ,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            System.Console.Write($"{matrix[i, j, k]}({i},{j},{k})");
        }
        System.Console.WriteLine();
    }
}

int[, ,] matrix = GetMatrix(2, 2, 2);
PrintMatrix(matrix);
