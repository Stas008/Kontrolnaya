string str;
string temp=String.Empty;
string[] words;
string[] result;
str=File.ReadAllText( "input.txt");
words=str.Split(' ', ',', ';', '’');
string Zadacha (string[] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        if (input[i].Length<=3)
        {
            temp=temp+input[i]+' ';
        }
    }
return temp;
}
void PrintStringArray (string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine(array[i]);   
    }
}
result=Zadacha(words).Split (' ');
PrintStringArray(result);
File.WriteAllText ("output.txt", temp);
temp=String.Empty;
