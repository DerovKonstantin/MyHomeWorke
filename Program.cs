
/*
//-------------------------------------------------------------

//  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//  m = 3, n = 4.
//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9


// создадим метод создания матрицы

void PrintArray(float[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FillArray(float[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = (float)new Random().NextDouble() * (10- (-10)) + (-10);
        }
    }
}

Console.Clear();
float[,] matrix = new float[3, 4];
FillArray(matrix);
PrintArray(matrix);

//-------------------------------------------------------------
*/

//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//  НапConsole.Clear()ример, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();

    }
}

/*
void FindIElement(int[,] matr, int x) // Найти значение элемента х
{ 
    int num = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == x) 
            {
                num = matr[i, j];
                Console.WriteLine("Значение этого элемента(The value of this element) = " + num);
            }  
        }
        x = x - 4;
    }
    if (x >= 0) Console.WriteLine("Данного елемента нет(This element does not exist)");
}

Console.Clear();
Console.Write("Ведит позицию искомого элемента(Maintains the position of the searched element): " );
int ipos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindIElement(matrix, ipos);
Console.WriteLine();

//------------------------------------------
*/

//  Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void SumOfColumnElements(int[,] matr) // Сумма элементов столбцов
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[j, i];
        }
        Console.WriteLine("Cреднее арифметическое элементов в(Arithmetic mean of elements in) " + i + " столбце(column): " + (sum / matr.GetLength(1)));
    }
}

Console.Clear();
int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SumOfColumnElements(matrix);
Console.WriteLine();


