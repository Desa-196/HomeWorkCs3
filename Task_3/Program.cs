﻿/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int N;

Console.Write("Введите число: ");

while(true)
{
    if( int.TryParse(Console.ReadLine(), out N ) )
    {
        break;
    }
    else
    {
        Console.Write("Введено некорректное число, повторите попытку ввода:");
    }
}

Console.Write($"Кубы чисел от 1 до {N}: |");

if(N > 0)
{
    for(int i=1; i <= N; i++)
    {
        Console.Write($" {Math.Pow(i, 3)} |");
    }
}
else
{
   for(int i=1; i >= N; i--)
    {
        Console.Write($" {Math.Pow(i, 3)} |");
    } 
}
