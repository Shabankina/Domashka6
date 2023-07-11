// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] a = new double[2] {2, 4};
double[] b = new double[2] {5, 9};

for (int i = 0; i < a.Length; i++)
{
  Console.Write (a[i] + " ");
}
Console.WriteLine();
for (int k = 0; k < b.Length; k++)
{
  Console.Write (b[k]+ " ");
}

double x = -(a[0] - a[1]) / (b[0] - b[1]);
double y = b[0] * x + a[0];

Console.WriteLine();
Console.WriteLine($"\n Точка пересечения двух прямых: [{x:f2},{y:f2}]");
