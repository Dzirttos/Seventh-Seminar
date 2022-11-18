// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Please number of lines in array: ");
int linesize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number of rows: ");
int rowsize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the first number from which array elements will be created: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the last number to which array elements will be created: ");
int end = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArray(linesize, rowsize, start, end);
ShowArray(array);
FindAverage(array);

int[,] CreateRandomArray(int lines, int rows, int min, int max)
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

double FindAverage(int[,] array)
{
    double average = 0;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        average = Convert.ToDouble(sum / array.GetLength(0));
        if (i == array.GetLength(1) -1 ) Console.Write($"{average:f1}.");    
        else Console.Write($"{average:f1}; "); 
    }
    return average;
}
