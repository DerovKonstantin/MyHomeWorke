/*
//-------------------------------------------------------------------------------------------------------------
//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//  a = 5; b = 7 -> max = 7
//  a = 2; b = 10 -> max = 10
//  a = -9; b = -3 -> max = -3

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2) Console.WriteLine("The first number is greater than the secon");
else Console.WriteLine("The second number is greater than the first");
//------------------------------------------------------------------------------

//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//  2 3 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int maxnum = 0;

if(num1 > maxnum) maxnum = num1;
if(num2 > maxnum) maxnum = num2;
if(num3 > maxnum) maxnum = num3;
Console.WriteLine("The maximum number will be: - " + maxnum);
//-----------------------------------------------------------

//  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//  4 -> да
//  -3 -> нет
//  7 -> нет

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0) Console.WriteLine("The number " + num + " is even");
else Console.WriteLine("The number " + num + " is not even");
//-------------------------------------------------------------------

//  Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 0;

while(current <= num)
{
    Console.Write(current + " ");
    current += 2;
}
//--------------------------------------------
*/