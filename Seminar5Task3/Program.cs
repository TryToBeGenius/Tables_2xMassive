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

void PrintArray(double[] array)
{
    Console.Write("[");
   for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write(array[i]);
        }

    }
    Console.Write("]");
}

double [] CreateArrayAvgForMatrixRow(int [,] matrix)
{   
    double [] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            sum += matrix[i,j];
        }
    array[i] = (double) sum / matrix.GetLength(1);
    }
    return array;
}

int [,] array2D = CreateMatrixRndInt(4,3, 1, 10);
PrintMatrix(array2D);

Console.WriteLine("");

double [] result = CreateArrayAvgForMatrixRow(array2D);
PrintArray(result);