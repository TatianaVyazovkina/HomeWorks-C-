/*
//Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵); 2, 4 -> 16
double ExponentNumber(int a, int b)
{
    double expon = Math.Pow(a, b);
    return expon;
}
Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());

double exponNumber = ExponentNumber(a, b);
Console.WriteLine($"Exponent {b} of number {a} is {exponNumber}");
*/
/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12

int SumDigitsNumber(int num)
{
    int sum = 0;
    while(num > 0)
    {
        int digit = num % 10;
        sum += digit;
        num = num / 10;
    }
    return sum;
}

Console.Write("Input a positive number:  ");
int num = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigitsNumber(num);
Console.WriteLine($"Sum of digits of number {num} is {sumDigits}");
*/
/*
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// m = 5 -> [1, 2, 5, 7, 19]; m = 3 -> [6, 1, 33]

int CheckSizeArray(int size)
{
    while(size <= 0)
    {
        Console.WriteLine("The array size is entered incorrectly!");
        Console.Write("Input the correct size of array: ");
        int sizenew = Convert.ToInt32(Console.ReadLine());
        size = sizenew;
        return size;
    }
    return size;
}

void ShowArray(int size, int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
        Console.Write($"Input the array element {i}:  ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        }           
    Console.WriteLine("My array:  ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input a size of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int check = CheckSizeArray(size);

int[] myArray = new int[check];
ShowArray(size, myArray);
*/