Console.WriteLine("Введите A: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B: ");
double b = Convert.ToDouble(Console.ReadLine());
if (a > b) Console.WriteLine($"a+b={a + b}");
else if (a == b) Console.WriteLine($"a*b={a * b}");
else Console.WriteLine($"a-b={a - b}");