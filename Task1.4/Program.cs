Console.WriteLine("Введите A: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите C: ");
double c = Convert.ToDouble(Console.ReadLine());
double d = b * b - 4 * a * c;
if (d < 0) Console.WriteLine("Корней нет");
else
{
    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine($"x1 = {x1}");
    Console.WriteLine($"x2 = {x2}");
}
