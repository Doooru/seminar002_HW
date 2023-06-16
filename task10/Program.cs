﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt (string message)
{
    System.Console.Write(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите число");
if (number < 100 || number >= 1000)
{
    Console.WriteLine ("число не трёхзначное");
    return;
}
Console.WriteLine ($"Введённое число {number}");
int second = number / 10 % 10;
Console.WriteLine ($"Вторая цифра {second}");