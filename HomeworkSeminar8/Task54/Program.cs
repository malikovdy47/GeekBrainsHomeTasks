﻿/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[m, n];
        CreateArray(array);
        WriteArray(array);

        Console.WriteLine($"\nCортированный массив: ");
        OrderArrayLines(array);
        WriteArray(array);

        void OrderArrayLines(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1) - 1; k++)
                    {
                        if (array[i, k] < array[i, k + 1])
                        {
                            int temp = array[i, k + 1];
                            array[i, k + 1] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }
        }

        int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        void CreateArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int range = InputNumbers("Введите диапазон: от 1 до ");
                    array[i, j] = new Random().Next(range);
                }
            }
        }

        void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();}
        }
    }            
}