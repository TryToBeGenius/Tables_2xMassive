char [,] Table1 = {{'a', 'b', 'c', 'd'},{'r', 's', 'e', 'h'}};

string FromMatrixToString(char [,] Matrix)
{
    string NewString = "";
    for(int i =0; i < Matrix.GetLength(0); i++)
    {
        for (int j =0; j < Matrix.GetLength(1); j++)
        {
            NewString += Matrix[i,j];
        }
    }
    return NewString;
}

string result = FromMatrixToString(Table1);
Console.WriteLine(result);