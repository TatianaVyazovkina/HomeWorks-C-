/*
//Задача 2. Напишите программу, на вход принимает 2 числа и выдает какое большее, а какое меньшее.
// a=5 b=7  max 7; a=2 b=10 max 10; a=-9 b=-3 max -3

Console.Write("Input firts number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second numbers: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
     Console.WriteLine($"Maximum number: {a} Minimal number: {b}");
}
else
{
    Console.WriteLine($"Maximum number: {b} Minimal number: {a}");
}

*/

/*
//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7; 44 5 78 -> 78; 22 3 9 -> 22

Console.Write("Input fist number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input three number: ");
int c = Convert.ToInt32(Console.ReadLine());


if(a > b && a > c)
{
    Console.WriteLine($"Maximum number: {a}");
}
else
{
    if(b > c)
    {
        Console.WriteLine($"Maximum number: {b}");
    }
    else
    {
        Console.WriteLine($"Maximum number: {c}");
    }
}

*/

/*
//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да; -3 -> нет; 7 -> нет

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine($"Number {number} is integer");
} 
else
{
    Console.WriteLine($"Number {number} is odd number");
}

*/

/*
//Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// 5 -> 2, 4; 8 -> 2, 4, 6, 8

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int curent = 1;

while(curent <= number)
{
    if(curent % 2 == 0)
    {
        Console.Write(curent + " ");
    }
    curent ++ ;
}
*/