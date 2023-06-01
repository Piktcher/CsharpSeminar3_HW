// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите 5-тизначное число, ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num < 9999) || (num > 99999)) Console.WriteLine("Введено не 5-тизначное число");
else
{
int digit1 = num / 10000;
int digit2 = num / 1000 % 10;
int digit4 = num % 100 / 10;
int digit5 = num % 10;

if ((digit1 == digit5) && (digit2 == digit4))
{
    Console.WriteLine("Введенное число - палиндром");
}
else Console.WriteLine("Введенное число не палиндром");
}
