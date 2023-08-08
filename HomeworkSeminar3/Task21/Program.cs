// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) 
// в пространстве: AB = √((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya) + (zb - za)*(zb - za))

Console.Write("Введите Xa : ");
int numberXa = int.Parse(Console.ReadLine());
Console.Write("Введите Ya : ");
int numberYa = int.Parse(Console.ReadLine());
Console.Write("Введите Ca : ");
int numberCa = int.Parse(Console.ReadLine());

Console.Write("Введите Xb : ");
int numberXb = int.Parse(Console.ReadLine());
Console.Write("Введите Yb : ");
int numberYb = int.Parse(Console.ReadLine());
Console.Write("Введите Cb : ");
int numberCb = int.Parse(Console.ReadLine());

double numXaYaCa = Math.Sqrt(Math.Pow(numberXb - numberXa, 2) + Math.Pow(numberYb - numberYa, 2) + Math.Pow(numberCb - numberCa, 2));
System.Console.WriteLine($"Расстояние {numXaYaCa}");