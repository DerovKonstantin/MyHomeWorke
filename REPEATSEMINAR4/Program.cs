int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
/*
//-------------------------------------------------------------------------------------------------------------
//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//  3, 5 -> 243 (3⁵)
//  2, 4 -> 16

void Exponentiation (int numberA, int numberB)
{
    int exponentnumber = 1;
    for(int i = 0; i < numberB; i++)
    {
        exponentnumber *= numberA;
    }
    Console.WriteLine("Number A to natural power B is " + exponentnumber);
}
Console.Clear();
int numberA = Input("Input first number (A) : ");
int numberB = Input("Input second number (B): ");
Exponentiation(numberA, numberB);
//-----------------------------------------------

//  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  452 -> 11
//  82 -> 10
//  9012 -> 12

int DigitInANumber(int dozens, int number)
{
    number = (number/dozens) %10;
    return number;
}

void SumOfTheDigitsInANumber (int number)
{
    int sum = 0;
    int dozens = 1;
    while(number > dozens)
    {
         sum += DigitInANumber(dozens, number);
         dozens *= 10; 
    }
    Console.WriteLine("The sum of the digits in a number is " + sum);
}

Console.Clear();
SumOfTheDigitsInANumber (Input("Input number: "));
//-------------------------------------------------------------------

//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
//  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//  6, 1, 33 -> [6, 1, 33]

void CreatArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length-1] + ".");
    Console.WriteLine();
}

Console.Clear();
int[] array = new int[8];
CreatArray(array);
PrintArray(array);
//----------------------------

*/