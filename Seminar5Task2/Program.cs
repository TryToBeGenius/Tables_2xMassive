int[,] CreateMatrixRndInt(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) первое измерение массива это Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) второе измерение массива Столбец ну типа X и Y на координатах
        {
            matrix[i,j] = rnd.Next(min, max);
        }
        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 4} ");
        }
        Console.WriteLine("");
    }
}

int SummDioganalOfMassive(int [,] matrix)
{
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i==j)
            {
                summ = summ + matrix[i,j];
            }
        }
    }
    Console.WriteLine($"Сумма чисел по диоганали:{summ}");
    return summ;
    
}

int[,] array2D = CreateMatrixRndInt(4,3, 1, 10);
PrintMatrix(array2D);
SummDioganalOfMassive(array2D);
