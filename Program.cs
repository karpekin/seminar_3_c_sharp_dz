// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное чило: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int a = number/10000;
// int b = number/1000%10;
// int c = number/10%10;
// int d = number%10;

// if (a == d && b == c)
// {  
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

//-----------------------------------------------------------------------------------------------------------------------
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите число X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Z2: ");
int Z2 = Convert.ToInt32(Console.ReadLine());

double d=Math.Round(Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2)),2);
Console.WriteLine(d);