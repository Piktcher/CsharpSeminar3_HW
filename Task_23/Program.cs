// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число больше 1, ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("Введенное число меньше 1, кубов не будет");
}
else
{
    int count = 1;
    while (count <= num)
    {
        Console.Write(Math.Pow(count, 3) + " ");
        count++;
    }
}