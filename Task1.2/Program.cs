Console.WriteLine("Введите X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y: ");
double y = Convert.ToDouble(Console.ReadLine());
if (x > 0 && y > 0) Console.WriteLine("Точка находится в 1 четверти");
else if (x < 0 && y > 0) Console.WriteLine("Точка находится в 2 четверти");
else if (x < 0 && y < 0) Console.WriteLine("Точка находится в 3 четверти");
else Console.WriteLine("Точка находится в 4 четверти");