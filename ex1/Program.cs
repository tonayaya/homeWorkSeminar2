﻿// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//  456 -> 5
//  782 -> 8 
//  918 -> 1


Console.Write("Введите трехзначное положительное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000) {
    num /= 10;
    num %= 10;
    Console.WriteLine($"Вторая цифра {num} ");
}
else Console.WriteLine(" Число не трехзначное!  ");