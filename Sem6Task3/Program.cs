int SummOfVowels(string s)
{
    string glssnie = "aeiouy";
    int cnt = 0;
    for (int i = 0; i < s.Length; i++)
    {
        for (int j = 0; j < glssnie.Length; j++)
        {
            if (s[i] == glssnie[j])
            {
                cnt++;
            }
        }
    }
    return cnt;
}
Console.WriteLine("Введите слово:");
string Strnew = Console.ReadLine();
Console.WriteLine($"В слове {SummOfVowels(Strnew)} гласных");
