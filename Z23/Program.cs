// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N = ");
int N = int.Parse(Console.ReadLine());
int a = 1;


while (a <= N)
{
      Console.WriteLine(Math.Pow(a,3));
      a = a + 1;
}
