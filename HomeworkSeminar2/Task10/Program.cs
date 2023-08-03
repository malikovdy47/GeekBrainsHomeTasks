// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter num : ");
string strNum = Console.ReadLine();

int num = int.Parse(strNum);

if (num > 99&&num < 1000)
    {
        int num2 = num % 100 / 10;
        Console.WriteLine($"{num2}");
    }
    else
    {
        Console.WriteLine("Введенное число не является трехзначным");
    }
