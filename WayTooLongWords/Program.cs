using static System.Console;
using static System.Convert;
using static System.Math;


int n;
n = ToInt32(ReadLine());
string[] arr = new string[101];
for (int i = 0; i < n; i++)
{
    string str = ReadLine();
    if (str.Length <= 10)
    {
        arr[i] = str;
    }
    else
    {
        arr[i] = $"{str[0]}{str.Length - 2}{str[str.Length-1]}";
    }
}
for (int i = 0; i < n; i++)
{
    WriteLine(arr[i]);
}