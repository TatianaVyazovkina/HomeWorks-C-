/*
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да

void Palindrom(int num)
{
int reverse = 0;
int number = num;
 while (num > 0)
 {
   reverse = reverse * 10 + num % 10;
   num = num / 10;
 }
 if(num == reverse)
 {
   Console.Write($"The number {number} is a Palindrom");
 }
else
{
   Console.Write($"The number {number} is not a Palindrom");
}
}

Console.Write("Input a five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);
*/

/*
//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53

double DistanBetweenPoints(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double b = x2 - x1;
    double c = y2 - y1;
    double d = z2 - z1;
    double b1 = Math.Pow(b, 2);
    double c1 = Math.Pow(c, 2);
    double d1 = Math.Pow(d, 2);
    double a1 = b1 + c1 + d1;
    double a = Math.Round(Math.Sqrt(a1), 2);
    return a;
}

Console.Write("Input x1-coordinates of the point A: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1-coordinates of the point A: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1-coordinates of the point A: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2-coordinates of the point B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x3-coordinates of the point B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2-coordinates of the point B: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ($"Distance between points with coordinates A({x1},{y1},{z1}) and B({x2},{y2},{z2}) is on the {DistanBetweenPoints(x1,y1,z1,x2,y2,z2)}");
*/

/*
//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void SquarNumber(int n)
{
    int num = 1;
    while(num <= n)
    {
       Console.Write($"{Math.Pow(num,3)} ");
       num++;
    }
}
Console.Write("Input number:  ");
int n = Convert.ToInt32(Console.ReadLine());
SquarNumber(n);
*/