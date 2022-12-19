// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки А, значение Ax = ");
int Ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки А, значение Ay = ");
int Ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки A, значение Az = ");
int Az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B, значение Bx = ");
int Bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B, значение By = ");
int By = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B, значение Bz = ");
int Bz = int.Parse(Console.ReadLine());


double result;
result = Math.Round(Math.Sqrt(Math.Pow((Bx - Ax),2) + Math.Pow((By - Ay),2) + Math.Pow((Bz - Az),2)),2);
Console.WriteLine(result);
