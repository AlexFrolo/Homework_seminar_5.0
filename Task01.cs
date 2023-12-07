//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет c#  

using System;

    public class Program {
    static void Main() {

    int[,] Array = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
    };

   
    Console.Write("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите номер столбца: ");
    int col = Convert.ToInt32(Console.ReadLine());

  
    if (row < 1 || row > Array.GetLength(0) || col < 1 || col > Array.GetLength(1)) {
        Console.WriteLine("Такого элемента не существует!");
    } else {
       
        Console.WriteLine($"Элемент с координатами ({row}, {col}) равен {Array[row - 1, col - 1]}.");

}
}
}