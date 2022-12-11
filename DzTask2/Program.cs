// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.Write("Введите значение 1 координаты 1 прямой: ");
double bOne= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение 2 координаты 2 прямой: ");
double kOne= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение 2 координаты 1 прямой: ");
double bTwo= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение 2 координаты 2 прямой: ");
double kTwo= Convert.ToDouble(Console.ReadLine());

double x = (bTwo - bOne) / ( kOne- kTwo);
double y = kOne * x + bOne;

Console.WriteLine($" Ваши прямые пересекуться в точке с координатами ({x} ,{y})");