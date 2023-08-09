// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Enter num1 : ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);

Console.WriteLine("Enter num2 : ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);

Console.WriteLine("Enter num3 : ");
string strNum3 = Console.ReadLine();
int num3 = int.Parse(strNum3);

Console.WriteLine("Enter num4 : ");
string strNum4 = Console.ReadLine();
int num4 = int.Parse(strNum4);

Console.WriteLine("Enter num5 : ");
string strNum5 = Console.ReadLine();
int num5 = int.Parse(strNum5);

Console.WriteLine("Enter num6 : ");
string strNum6 = Console.ReadLine();
int num6 = int.Parse(strNum6);

Console.WriteLine("Enter num7 : ");
string strNum7 = Console.ReadLine();
int num7 = int.Parse(strNum7);

Console.WriteLine("Enter num8 : ");
string strNum8 = Console.ReadLine();
int num8 = int.Parse(strNum8);

int[] numbers = {num1, num2, num3, num4, num5, num6, num7, num8};
Console.Write($"[{num1}, {num2}, {num3}, {num4}, {num5}, {num6}, {num7}, {num8}]");