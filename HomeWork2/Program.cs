/*
//Задача 1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1

int InputSecondNumber(int num)
{
    int count;
    count = num % 100 / 10;
    return count;
}
  
 Console.Write("Input three-digit number: ");
 int num = Convert.ToInt32(Console.ReadLine());
 int secondNumber = InputSecondNumber(num);
 Console.WriteLine($"The second digit of {num} is {secondNumber}");
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

int InputThreeNumber(int number)
{
int count;
int num = number;
while(num > 999 )
{
    count = num / 10;
    num = count;
}
int countEd;
if(num > 99 && num < 999)
{
    countEd = num % 10;
    return countEd;
}
else
{
    return number;
}

}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 100)
{
    Console.WriteLine($"The numbers {number} three-digits no");  
}
else
{
int threeNumber = InputThreeNumber(number);
Console.WriteLine($"The three digit of {number} is {threeNumber}"); 
}

*/

/*
//Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да ; 7 -> да ; 1 -> нет

string WeekindWordDay (int num)
{
if(num > 0 && num < 8)
{
    if(num == 6 || num == 7)
    {
        Console.WriteLine($"{num} - weekind");
    }
    else
    {
        Console.WriteLine($"{num} - workday");
    }
}
else
{
    Console.WriteLine("Incorrectly entered a digit from range 1 to 7");
}
return "day";
}

Console.Write("Input number day in week in the range from 1 to 7:  ");  // [1,7] 1- monday; 2- tuesday; 3-wednesday; 4-Thursday; 5-friday; 6-saturday; 7-sunday
int num = Convert.ToInt32(Console.ReadLine());
string weekindWord = WeekindWordDay (num);
*/