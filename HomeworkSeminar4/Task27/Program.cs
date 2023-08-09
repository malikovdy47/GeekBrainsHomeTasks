// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter num : ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

  int SumNum(int num)
  {
    
    int count = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
  }

int sumNum = SumNum(num);
Console.WriteLine("Сумма цифр в числе: " + sumNum);