// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.

int conStrInt(string massageEnt)
{
    Console.WriteLine("massageEnt");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Pow(int num, int runk)
{
    int numPow = num;
    for (int i = 0; i < runk; i++)
    {
        numPow *= num;
    }
    return numPow;
}
int numA = conStrInt("Введите число А: ");
int numB = conStrInt("Введите число B: ");

int result = Pow(numA, numB);

Console.WriteLine($"Число {numA} в степени {numB} равно {result}");