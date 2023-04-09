string[] string1 = { "hello", "2", "world", ":-)" };
string[] string2 = { "1234", "1567", "-2", "computer science" };
string[] string3 = { "Russia", "Denmark", "Kazan" };

Console.WriteLine($"[{String.Join(", ", string1)}] -> [{String.Join(", ", ShortStringsArr(string1))}]");
Console.WriteLine($"[{String.Join(", ", string2)}] -> [{String.Join(", ", ShortStringsArr(string2))}]");
Console.WriteLine($"[{String.Join(", ", string3)}] -> [{String.Join(", ", ShortStringsArr(string3))}]");

string[] ShortStringsArr(string[] str)
{
    string[] string1 = new string[str.GetLength(0)];
    int count = 0;
    for (int i = 0; i < str.GetLength(0); i++)
    {
        if (str[i].Length <= 3)
        {
            string1[count] = str[i];
            count++;
        }
    }

    string[] string2 = new string[count];
    for (int i = 0; i < count; i++)
    {
        string2[i] = string1[i];
    }
    return string2;
}