string Stroka1 = "AaBbCcDddDcCbBaA";

string FromBigToSmallLeters(string s)
{
    string BigLetters = "ABCDEFGHIJKLMNOPQRSTWXYZ";
    string SmallLetters = "abcdefghijqlmnopqrstwxyz";
    string NewString = "";
    for (int i = 0; i < s.Length; i++)
    {
        for (int j = 0; j < BigLetters.Length; j++)
    {
        if (s[i] == BigLetters[j])
        {
                
            NewString += SmallLetters[j];
        }
        if (s[i] == SmallLetters[j])
        {
            NewString += SmallLetters[j];
        }
        
    }
    }
    return NewString;
}

string result = FromBigToSmallLeters(Stroka1);
Console.WriteLine(result);
