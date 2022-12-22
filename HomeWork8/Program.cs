//Задача 54:Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
*/
/*
void SortToLower(int[,] array)
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

Console.Write("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;

int[,] myArray = Create2DArrayRandomInt(rows, columns, min, max);

Print2DArrayInt(myArray);

SortToLower(myArray);
Console.WriteLine();
Print2DArrayInt(myArray);
*/

//Задача 56: Задайте прямоугольный двухмерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minRow += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
        sumRow += array[i, j];
        }
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
   
    Console.Write($"{minSumRow + 1} string");
}

Console.Write("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 9;

int[,] myArray = Create2DArrayRandomInt(rows, columns, min, max);

Print2DArrayInt(myArray);

NumberRowMinSumElements(myArray);
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
Console.Write("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 9;

int[,] array = Create2DArrayRandomInt(rows, columns, min, max);
int[,] secondArray = Create2DArrayRandomInt(rows, columns, min, max);
int[,] resultArray = new int[rows, columns];

Print2DArrayInt(array);

Console.WriteLine();

Print2DArrayInt(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("You can't multiply!");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

Print2DArrayInt(resultArray);
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int[,,] Create3DArrayRandomInt(int elem1, int elem2, int elem3, int minValue, int maxValue)
{
    int[,,] array = new int[elem1, elem2, elem3];
    for (int i = 0; i < elem1; i++)
    {
        for (int j = 0; j < elem2; j++)
        {
            for (int k = 0; k < elem3; k++)
            {
            array[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return array;
}
void Print3DArrayInt(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
            Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            if (k < array.GetLength(2) - 1)
                Console.Write(" \t");
        }
        if (j < array.GetLength(1) - 1)
            Console.WriteLine(" \t");
        }
    if (i < array.GetLength(0)-1)
        Console.WriteLine(" \t");

    else Console.WriteLine(" ");
    }
}
Console.Write("Input a numbers of elem1: ");
int elem1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of elem2: ");
int elem2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of elem3: ");
int elem3 = Convert.ToInt32(Console.ReadLine());
int min = 10;
int max = 99;

int[,,] myArray = Create3DArrayRandomInt(elem1, elem2, elem2, min, max);

Print3DArrayInt(myArray);
*/
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*
void Fill2DArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input size 2D array: ");
int len = Convert.ToInt32(Console.ReadLine());
int[,] myArray = new int[len, len];
Fill2DArraySpiral(myArray, len);
PrintArray(myArray);
*/