string str;
string[] words;
string[] result;
str=File.ReadAllText( "input.txt");
words=str.Split(' ', ',', ';', '’');
void Zadacha (string[] input, string[] output)
{
    int j=0;
    for (int i = 0; i < input.GetLength(0); i++)
    {
        if (input[i].Length<=3)
        {
            output[j]=input[i];
            j++;
        }
    }
}