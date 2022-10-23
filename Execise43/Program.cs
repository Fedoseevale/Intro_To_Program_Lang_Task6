// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double X (double be1, double kei1, double be2, double kei2)
{
    double iks = Math.Round (((be2 - be1) / (kei1 - kei2)), 1);
    return iks;
}

double Y (double be_1, double kei_1, double be_2, double kei_2)
{
    double igrek = Math.Round ((kei_2*(be_2 - be_1) / (kei_1 - kei_2) + be_2), 1);
    return igrek;
}

Console.WriteLine("Даны два уравнения: y = k1 * x + b1, y = k2 * x + b2");

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = X(b1, k1, b2, k2);
double y = Y(b1, k1, b2, k2);

Console.WriteLine ($"Точка пересечения двух прямых, заданных уравнениями: ({x}, {y})");