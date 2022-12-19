// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число N: = ");
int N = int.Parse(Console.ReadLine());

int a1 = N/10000;
 //Console.WriteLine(a1);
int a2 = N/1000%10;
//Console.WriteLine(a2);
int b1 = N%10;
//Console.WriteLine(b1);
int b2 = N/10%10;
//Console.WriteLine(b2);
 
if(a1==b1 & a2==b2)
 {
   Console.WriteLine("да");
 }
 else
 {
   Console.WriteLine("нет");
 }
