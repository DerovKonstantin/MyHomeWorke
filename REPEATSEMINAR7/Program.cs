
/*
//-----------------------------------------------------------------------------------------------
// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void CreatMatrix(double[,] creatmatrix)
{
    for(int i = 0; i < creatmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < creatmatrix.GetLength(1); j++)
        {
            creatmatrix[i, j] = Convert.ToDouble(new Random().Next(-10, 100))/10;
        }
    }
}

void PrintMatrix(double[,] printmatrix)
{
    for(int i = 0; i < printmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < printmatrix.GetLength(1); j++)
        {
            if( printmatrix[i, j] >= 0 )
            {
                string result = string.Format("{0:f1}", printmatrix[i, j]);
                Console.Write(" " + result + " ");
            }
            else
            {
                string result = string.Format("{0:f1}", printmatrix[i, j]);
                Console.Write(result + " ");
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
double[,] matrix = new double[3, 4];
CreatMatrix(matrix);
PrintMatrix(matrix);
//----------------------------------------------------------------------------------------------

// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void CreatMatrix(int[,] creatmatrix)
{
    for(int i = 0; i < creatmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < creatmatrix.GetLength(1); j++)
        {
            creatmatrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] printmatrix)
{
    for(int i = 0; i < printmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < printmatrix.GetLength(1); j++)
        {
                Console.Write(printmatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void SearchMatrixElement(int[,] inmatrix)
{
    int x = Input("Enter line number -> ");
    int y = Input("Enter column number -> ");

    if(x < inmatrix.GetLength(0) && y < inmatrix.GetLength(1))
    {
        Console.WriteLine(inmatrix[x, y]);
    }
    else
    {
        Console.WriteLine("Element not found");
    }
}

Console.Clear();
int[,] matrix = new int[3, 4];
CreatMatrix(matrix);
PrintMatrix(matrix);
SearchMatrixElement(matrix);
//-----------------------------------------------------------------------------------

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void CreatMatrix(int[,] creatmatrix)
{
    for(int i = 0; i < creatmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < creatmatrix.GetLength(1); j++)
        {
            creatmatrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] printmatrix)
{
    for(int i = 0; i < printmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < printmatrix.GetLength(1); j++)
        {
                Console.Write(printmatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SumColumnElements(int[,] inmatrix)
{
    for (int i = 0;i < inmatrix.GetLength(1); i++)
    {
        double sumelements = 0;
        for (int j = 0; j < inmatrix.GetLength(0); j++)
        {
            sumelements += inmatrix[j, i];
        }
        Console.WriteLine("Arithmetic mean of elements in " + i + " column = " + (sumelements / inmatrix.GetLength(1)));
    }
}

Console.Clear();
int[,] matrix = new int[3, 4];
CreatMatrix(matrix);
PrintMatrix(matrix);
SumColumnElements(matrix);
//--------------------------
*/