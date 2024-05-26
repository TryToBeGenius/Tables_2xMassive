   
            
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

void ChetIndexChangeToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2) //i++
    {
       for(int j = 0; j < matrix.GetLength(1); j+=2) //j++
        {
            //if (i % 2 == 0 && j % 2 == 0)
            //{
                matrix[i,j] *= matrix[i,j];
            //}
        }
    }
}

int [,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
ChetIndexChangeToSquare(array2D);
Console.WriteLine("");
PrintMatrix(array2D);