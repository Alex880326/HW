﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
System.Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number % 100;
int number3 = number2 /10;

if (number < 1000)
{
    System.Console.WriteLine(number3);
}
else
{
    System.Console.WriteLine("Число не трехзначное, попробуйте еще раз ");
}

