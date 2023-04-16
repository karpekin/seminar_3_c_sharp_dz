// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное чило: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = number/10000;
int b = number/1000%10;
int c = number/10%10;
int d = number%10;

if (a == d && b == c)
{  
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}