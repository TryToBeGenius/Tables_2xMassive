int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(10, 100);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void InterestedDigitOfMatrix(int[,] matrix)
{   
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((matrix[i,j] / 10 + matrix[i,j] % 10) % 2 == 0)
                {
                    
                    count ++;
                    Console.Write($"{matrix[i, j]}, ");
                }

        }
        
    }
    Console.Write($"Колличество чисел:{count}");
}

int [,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);
Console.Write("ИТОГО: ");
InterestedDigitOfMatrix (matrix);
