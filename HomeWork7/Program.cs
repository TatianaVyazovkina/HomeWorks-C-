// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] Create2DArrayRandomDouble(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
        }  
    }
    return array;
}
void Print2DArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(" \t");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(" \t");
        else Console.WriteLine(" ");
    }
}

Console.Write("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] myArray = Create2DArrayRandomDouble(rows, columns);

Print2DArrayDouble(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void Print2DArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(" \t");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(" \t");
        else Console.WriteLine(" ");
    }
}
bool CheckNumber2D(int num, int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            if(array[i,j] == num)
            
            return true;
        }
    }
    return false;
}

Console.Write("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;

int[,] myArray = Create2DArrayRandomInt(rows, columns, min, max);

Print2DArrayInt(myArray);

Console.Write($"Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool find = CheckNumber2D(num, myArray);
Console.Write($"Is there a given number {num} in my 2D array: {find} ");
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void Print2DArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(" \t");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(" \t");
        else Console.WriteLine(" ");
    }
}
Console.Write("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 100;

int[,] myArray = Create2DArrayRandomInt(rows, columns, min, max);

Print2DArrayInt(myArray);

for(int j = 0; j < myArray.GetLength(0); j++)
    {
        double sum = 0;
        for(int i = 0; i < myArray.GetLength(0); i++)
        {
            sum += myArray[i,j];
        }
        double average = sum / myArray.GetLength(0);
        
        Console.Write($"{average}    ");
    }
