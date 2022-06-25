void PrintArray(int[] printarray)
{
    for (int i = 0; i < printarray.Length-1; i++)
    {
        Console.Write(printarray[i] + ", ");
    }
    Console.WriteLine(printarray[printarray.Length-1] + ".");
}
/*
//-------------------------------------------
//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2

void CreatArray(int[] creatarray)
{
    for (int i = 0; i < creatarray.Length; i++)
    {
        creatarray[i] = new Random().Next(100, 1000);
    }
}

void HowManyEvenNumbersInTheArray(int[] inarray)
{
    int count = 0;
    for (int i = 0; i < inarray.Length; i++)
    {
        if(inarray[i] % 2 == 0)
        count++;
    }
    Console.WriteLine("Even numbers in array = " + count);
}

Console.Clear();
int[] array = new int[4];
CreatArray(array);
PrintArray(array);
HowManyEvenNumbersInTheArray(array);
//----------------------------------

//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//  [3, 7, 23, 12] -> 19
//  [-4, -6, 89, 6] -> 0

void CreatArray(int[] creatarray)
{
    for (int i = 0; i < creatarray.Length; i++)
    {
        creatarray[i] = new Random().Next(-10, 100);
    }
}

void SumElementsOddPositions(int[] inarray)
{
    int sumelements = 0;
    for (int i = 1; i < inarray.Length; i+=2)
    {
        sumelements += inarray[i];
    }
    Console.WriteLine("Sum of elements of odd positions = " + sumelements);
}

Console.Clear();
int[] array = new int[4];
CreatArray(array);
PrintArray(array);
SumElementsOddPositions(array);
//-----------------------------

//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//  [3 7 22 2 78] -> 76

void CreatArray(int[] creatarray)
{
    for (int i = 0; i < creatarray.Length; i++)
    {
        creatarray[i] = new Random().Next(0, 100);
    }
}

void DifferenceMaximumMinimumArrayElements(int[] inarray)
{
    int maxements = inarray[0];
    int minements = inarray[0];
    int difference = 0;

    for (int i = 0; i < inarray.Length; i++)
    {
        if(inarray[i] > maxements)
        maxements = inarray[i];

        if(inarray[i] < minements)
        minements = inarray[i];
    }

    difference = maxements - minements;
    Console.WriteLine("Difference between maximum and minimum elements = " + difference);
}

Console.Clear();
int[] array = new int[4];
CreatArray(array);
PrintArray(array);
DifferenceMaximumMinimumArrayElements(array);
//-------------------------------------------
*/