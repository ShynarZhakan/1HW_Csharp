﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (num % 2 == 1)
{
    num = num - 1;
}

else 
{
    num = num;
}

while (i <= num)
{
    Console.WriteLine(i);
    i+=2;
}