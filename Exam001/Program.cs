string[] array = { "12", "567", "1234", "as", "tyhb" };

string[] result = new string[array.Length];
int i = 0;
foreach (string value in array)
{
    if (value.Length <= 3)
    {
        result[i] = value;
        i++;
    }
}

Console.WriteLine(string.Join(Environment.NewLine, result, 0, i));