//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

namespace FindMinSumElements
{
    class Program
{
    static void Main(string[] args) {
    int[,] arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } }; 
    int sum = 0, minSum = int.MaxValue; 
    int minRowIndex = 0; 

      
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j]; 
            }
            if (sum < minSum) 
            {
                minSum = sum;
                minRowIndex = i;
            }
            Console.WriteLine($"Строка с минимальной суммой: {minRowIndex}"); 
        
            Console.ReadKey();
        }

        
    }

}}