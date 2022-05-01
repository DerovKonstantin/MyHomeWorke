
/*
--------------------------------------------------------------------------------------------------------------------

//  Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//  3, 5 -> 243 (3⁵)

//  2, 4 -> 16

// Решение

Console.Clear();
void Exponentiation (int numa, int numb)
{
    int expnum = 1;

    for(int i = 0; i < numb; i++)
    {
        expnum = expnum * numa;
    }
    Console.WriteLine("Number A to natural power B is " + expnum);
}

Console.Write("Input first number (A) : ");
int numa = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number (B): ");
int numb = Convert.ToInt32(Console.ReadLine());
Exponentiation(numa, numb);

------------------------------------------------------------------------------------------------

//  Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//  452 -> 11

//  82 -> 10

//  9012 -> 12

// Решение

Console.Clear();
void Exponentiation (int expnum)
{
    int sumnum = 0;
    int proxynum = expnum;
    for(int i = 0; i < expnum ; i++)
    {
        sumnum = (proxynum - ((proxynum / 10) * 10)) + sumnum;
        proxynum = proxynum / 10;
        expnum = expnum / 10;  
    }

    if(expnum == 0)
        {
            Console.WriteLine("Sum of the number is " + sumnum);
        }
    if(expnum == 1)
        {
            sumnum = sumnum + 1;
            Console.WriteLine("Sum of the number is  " + sumnum);
        }
}

Console.Write("Input number: ");
int expnum = Convert.ToInt32(Console.ReadLine());
Exponentiation (expnum);

---------------------------------------------------------------------------------------------

//  Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//  6, 1, 33 -> [6, 1, 33]

// Решение
*/

Console.Clear();
void ShowArrayFor(int[] arrayfor)
{
    int length = arrayfor.Length;
    int index = 0;
    while (index < length)
    {
        arrayfor[index] = new Random().Next(1,100);
        Console.Write(arrayfor[index] + ", ");
        index++;
    }
   
    Console.WriteLine(" ");
}

ShowArrayFor(new int[8]);

