﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет. Не использовать массив
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Enter num : ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{while (num > 999)
{
num /= 10;
}
num = num % 10;
Console.WriteLine($"{num}");}