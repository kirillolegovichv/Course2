Console.WriteLine("Введите двузначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string dec;
string un;
if (a > 19)
{
    int decade = a / 10;
    int unit = a % 10;
    if (decade == 2) dec = "двадцать";
    else if (decade == 3) dec = "тридцать";
    else if (decade == 4) dec = "сорок";
    else if (decade == 5) dec = "пятдесят";
    else if (decade == 6) dec = "шестьдесят";
    else if (decade == 7) dec = "семдесят";
    else if (decade == 8) dec = "восемдесят";
    else dec = "девяносто";
    if (unit == 1) un = "один";
    else if (unit == 2) un = "два";
    else if (unit == 3) un = "три";
    else if (unit == 4) un = "четыре";
    else if (unit == 5) un = "пять";
    else if (unit == 6) un = "шесть";
    else if (unit == 7) un = "семь";
    else if (unit == 8) un = "восемь";
    else un = "девять";
    Console.WriteLine($"{dec} {un}");
}
else
{
    if (a == 10) Console.WriteLine("десять");
    else if (a == 11) Console.WriteLine("одиннадцать");
    else if (a == 12) Console.WriteLine("двенадцать");
    else if (a == 13) Console.WriteLine("тринадцать");
    else if (a == 14) Console.WriteLine("четырнадцать");
    else if (a == 15) Console.WriteLine("пятнадцать");
    else if (a == 16) Console.WriteLine("шестнадцать");
    else if (a == 17) Console.WriteLine("семнадцать");
    else if (a == 18) Console.WriteLine("восемнадцать");
    else if (a == 19) Console.WriteLine("девятнадцать");
}