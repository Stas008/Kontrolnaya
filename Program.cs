string str;
string[] words;
string[] output;
str=File.ReadAllText( "input.txt");
words=str.Split(' ', ',', ';', '’');