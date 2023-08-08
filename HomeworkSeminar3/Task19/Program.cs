// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Enter a five-digit number: ");
string number = Console.ReadLine();
int num = number.Length;

if (num == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine($"Введенное пятизначное число: {number} - палиндром");
    }

    else
    {
        Console.WriteLine($"Введенное пятизначное число: {number} - не палиндром");
    }
}
else
{
    Console.WriteLine("The number is not five digits");
}