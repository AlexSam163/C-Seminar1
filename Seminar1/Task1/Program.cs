﻿
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3*/

Console.Clear();

Console.WriteLine("Введите первое число");
int namberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int namberY = Convert.ToInt32(Console.ReadLine());

if (namberX > namberY)

{
    Console.WriteLine("max = " +namberX);
}
else
{
    Console.WriteLine("max = " + namberY);
}
