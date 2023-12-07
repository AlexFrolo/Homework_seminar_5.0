
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

using System;

class Program
{
    static void Main()
    {
        
        int[,] array = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

       
        Console.WriteLine("Исходный массив:");

        PrintArray(array);

        int rowCount = array.GetLength(0);

        int colCount = array.GetLength(1);

        for (int i = 0; i < colCount; i++)
        {
            int temp = array[0, i];

            array[0, i] = array[rowCount - 1, i];

            array[rowCount - 1, i] = temp;
        }

       
        Console.WriteLine("Измененный массив:");

        PrintArray(array);
    }

    static void PrintArray(int[,] array)
    {
        int rowCount = array.GetLength(0);

        int colCount = array.GetLength(1);
        
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}