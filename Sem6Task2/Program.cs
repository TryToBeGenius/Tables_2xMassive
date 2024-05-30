Console.WriteLine("Введите строку");
string str = Console.ReadLine();
char[] FromStringToMassive(string s)
{
    
    char[] array = new char[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        array[i] = s[i];
        
    }
return array;
    
}

void PrintArray(char[] array1)
{
    Console.Write("[");
   for (int i = 0; i < array1.Length; i++)
    {
        if (i < array1.Length - 1)
        {
            Console.Write($"{array1[i]}, ");
        }
        else
        {
            Console.Write(array1[i]);
        }

    }
    Console.Write("]");
}

char [] resArray = FromStringToMassive(str);
PrintArray(resArray);
