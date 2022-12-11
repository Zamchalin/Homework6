// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.




double Long(double a1, double b1, double a2, double b2)
{
double result = Convert.ToDouble(Math.Sqrt(Math.Pow((b2 - b1), 2) + Math.Pow((a2 - a1), 2)));
return  Math.Round(result, 2);

}
Console.Clear();
Console.Write("Введите значение 1 координаты 1 точки: ");
double x1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 2 координаты 1 точки: ");
double y1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 1 координаты 2 точки: ");
double x2= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 2 координаты 2 точки: ");
double y2= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 1 координаты 3 точки: ");
double x3= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 2 координаты 3 точки: ");
double y3= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Длинна первого отрезка: {Long(x1, y1, x2, y2)}");
double long1 = Long(x1, y1, x2, y2);
Console.WriteLine($"Длинна второго отрезка: {Long(x2, y2, x3, y3)}");
double long2 = Long(x2, y2, x3, y3);
Console.WriteLine($"Длинна третьего отрезка: {Long(x1, y1, x3, y3)}");
double long3 = Long(x1, y1, x3, y3);

double longMax = long1;
if(longMax < long2)
    longMax = long2;
if(longMax < long3)
    longMax = long3;
Console.WriteLine($"Длинна основания треугольника ровна : {longMax}");

double h = Convert.ToDouble(Math.Sqrt(Math.Pow(long2, 2) - Math.Pow((longMax / 2), 2)));
h = Math.Round(h , 2);
Console.WriteLine($"Высота  треугольника ровна : {h}");


double s = h * longMax / 2;
s = Math.Round(s, 2);

Console.WriteLine($"Площадь треугольника ровна : {s}");
