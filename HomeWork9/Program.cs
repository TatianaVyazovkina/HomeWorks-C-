// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

Console.Write("Input number n: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 2;

PrintNumber(n, count);
Console.Write(1);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30
/*
int SumMN(int m, int n)
{
    int res = m;
    if (m >= n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumMN(m-1, n);
Console.WriteLine($"Summa of natural numbers of range from {m} to {n} is {result}");
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Input number M:  ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N:  ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int m, int n)
{
    if (m == 0) 
        return n + 1;

    if (m != 0 && n == 0) 
        return AckermannFunction(m - 1, 1);

    if (m > 0 && n > 0) 
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));

return AckermannFunction(m, n);
}
Console.WriteLine($"Ackerman function for numbers A({m},{n}) = {AckermannFunction(m, n)}");