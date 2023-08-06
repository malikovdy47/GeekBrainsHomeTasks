// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Enter num : ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num <= 0)
{
    Console.WriteLine($"{num} - это не день недели");
}
else if (num >= 8)
{
    Console.WriteLine($"{num} - это не день недели");
}
else if (num >= 6 && num < 8)
{
    Console.WriteLine($"{num} - это выходной");
}
else if (num < 6)
{
    Console.WriteLine($"{num} - это будний день");
}