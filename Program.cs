/*

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num * num;

Console.WriteLine("Result is " + result);



// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3



Console.Write("Input first integer number: ");
int a - Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int b - Convert.ToInt32(Console.ReadLine());

if (a > b) max = a;
if (a < b) max = b;

Console.WriteLine ("max = " + max)

*/

int a = -9;
int b = -3;

int max = a;

if (a > b) max = a;
if (a < b) max = b;

Console.Write("max = ");
Console.WriteLine(max);
