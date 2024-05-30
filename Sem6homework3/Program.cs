Console.WriteLine("Введите строку:");
string rndStr = Console.ReadLine();

bool IsItPolindrom(string s)
{
    for(int i = 0; i < s.Length/2; i++)
    {
        if(s[i] == s[s.Length - i-1])
        {
            continue;
        }
        else 
        {
            Console.Write("Нет");
            return false;
            break;
        }
    }
    Console.Write("Да");
    return true;
    
}

Console.Write("Это полиндром? :");
IsItPolindrom(rndStr);