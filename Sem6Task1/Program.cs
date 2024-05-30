string CharArrayToString(char [] arr)
{
    string res ="";
    for (int i = 0; i < arr.Length; i++)
    {
        res+= arr[i];
    }
    return res;

}

char [] array = { 'a', 'b', 'c', 'd', 'e', 'f'};
string result = CharArrayToString(array);
Console.WriteLine(result);