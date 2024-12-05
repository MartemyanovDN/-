
string CreatePhoneNumber(int[] number)
{
    string str = "";
    if (number.Length != 10)
    {
        str = "Неправильно набран номер";
    }
    else
    {
        str = $"+8 ({number[0]}{number[1]}{number[2]}) " +
            $"{number[3]}{number[4]}{number[5]}" +
            $"-{number[6]}{number[7]} {number[8]}{number[9]}";
    }
    return str;
}

int[] number = { 9, 2, 3, 1, 2, 0, 0, 9, 8, 1 };
Console.WriteLine(CreatePhoneNumber(number));

string TrimString(int strmax, string str)
{
    if (str.Length > strmax)
    {
        str = str.Substring(0, strmax);
        str += "...";
    }
    return str;
}

string str = ("Hello world");
Console.WriteLine(TrimString(7, str));


namespace строки
{
    internal class Program
        

    {
        static void Main(string[] args)
        {
            
            
        }
    }
}
