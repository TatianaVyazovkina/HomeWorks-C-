
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
*/
/*
int CounterEvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        int even = array[i] % 2;
        if(even == 0)
            count ++;
    }
    return count;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;

int[] myArray = CreateRandomArray(size, min, max);
int result = CounterEvenNumber(myArray);

ShowArray(myArray);
Console.WriteLine("Number of even array elements is " + result);
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0
/*
int SumElements(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, -100, 100);
int result = SumElements(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of a odd elements is " + result);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
int MinElements(int[] array)
{
    int mini = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(mini > array[i])
            mini = array[i];
    }             
    return mini; 
}

int MaxElements(int[] array)
{
    int maxi = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(maxi < array[i])
            maxi = array[i]; 
    }
    return maxi;
}   

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, 0, 100);
int result = MaxElements(myArray) - MinElements(myArray);

ShowArray(myArray);
Console.WriteLine("The difference between the minimum and maximum number of an array is  " + result);
*/