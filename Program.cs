/*

// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

// Первый вариант оформления первой задачи

int a = -9;
int b = -3;

if (a > b) max = a;
if (a < b) max = b;

Console.Write("max = ");
Console.WriteLine(max);

// Второй вариант оформления первой задачи

Console.Write("Input first integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int b = Convert.ToInt32(Console.ReadLine());

int max =a;

if (a > b) 
    max = a;
else
    max = b;

Console.Write("max = ");
Console.WriteLine(max);



// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

// Решение второй задачи

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max =num1;

if (num1 > max)  max = num1;
if (num2 > max)  max = num2;
if (num3 > max)  max = num3;

Console.Write("max = ");
Console.WriteLine(max);



// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

// Решение третьей задачи

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int x = (num % 2);

if (x == 0)   
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("The number is odd");
}



// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

// Решение четвертой задачи

*/

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());