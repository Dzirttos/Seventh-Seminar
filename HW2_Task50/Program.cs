﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Please number of lines in array: ");
int linesize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number of rows: ");
int rowsize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter array element line position: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter array element row position: ");
int r = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateArray(linesize, rowsize, 1, 100);
ShowArray(newArray);

if (l > linesize || r > rowsize)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("There is no such element in the array!");
}

for (int i = 0; i < linesize; i++)
{
    if (i == l - 1)
    {
        for (int j = 0; j < rowsize; j++)
        {
            if (j == r - 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"The element of array standing in {l} line and in {r} row is {newArray[i, j]}.");
            }
        }
    }
}


int[,] CreateArray(int lines, int rows, int min, int max)
{
    int[,] myArray = new int[lines, rows];
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return myArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }

}

