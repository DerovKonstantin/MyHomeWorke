/*
//-------------------------------------------------------------

//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

//  Например, задан массив:

//  1 4 7 2
//  5 9 2 3
//  8 4 2 4

//  В итоге получается вот такой массив:

//  1 2 4 7
//  2 3 5 9
//  2 4 4 8


// создадим метод создания матрицы

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

*/
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i, j] < 10) Console.Write("   " + matr[i, j]);
            if(matr[i, j] >= 10 && matr[i, j] < 100) Console.Write("  " + matr[i, j]);
            if(matr[i, j] >= 100 && matr[i, j] < 1000) Console.Write(" " + matr[i, j]);
            //Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
/*

void ElementsOfEachRowInAscendingOrder(int[,] array) // Элементы каждой строки по возрастанию
{
    for(int i = 0; i < array.GetLength(0)-1; i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        { 
            for (int c = j + 1; c < array.GetLength(1); c++)
            {
                if(array[i,c] < array[i,j])
                {
                    int temporary = array[i,j];
                    array[i,j] = array[i,c];
                    array[i,c] = temporary;
                }
            } 
        }
    }
}

Console.Clear();
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ElementsOfEachRowInAscendingOrder(matrix);
PrintArray(matrix);

//-------------------------------------------------------------

//  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7

void FindingTheRowWithTheSmallestSumOfElements(int[,] array) // Поиск  строки с наименьшей суммой элементов
{
    int ns = 0;  // номер строки
    int mses = 100;    // минимальная сумма элементов строки
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int ses = 0;  // сумма элементов строки
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            ses += array[i,j];
        }
        if(mses > ses )
        {
            mses = ses;
            ns = i;
        }  
    }

    Console.Write("Строка с наименьшей суммой элементов (The row with the smallest sum of elements) - " + ns);
    Console.WriteLine();
}
       
Console.Clear();
int[,] matrix = new int[4, 3];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindingTheRowWithTheSmallestSumOfElements(matrix);
Console.WriteLine();

//-------------------------------------------------------------

//  Задача 62. Заполните спираspiraльно массив 4 на 4.

//  Например, на выходе получается вот такой массив:

//  1 2 3 4
//  12 13 14 5
//  11 16 15 6
//  10 9 8 7

*/

void SpiralMatrix(int[,] spiral)
{
    int s = 0; // изменения на размер "с" после 1 прохода
    int z = 0; // нулевая точька
    int i = 0; // щетчик одного перемещения, лево-право, вверх-низ
    int c = 1; // общий щетчик
    int vc = spiral.GetLength(0); // колличество знаков в высота
    int dc = spiral.GetLength(1); // колличество знаков в длинна
    int v = spiral.GetLength(0); // высота
    int d = spiral.GetLength(1); // длинна
    while (c < spiral.GetLength(0)*spiral.GetLength(1)) // общее колличество циклов
    {
        i = 0;
        while(c < (dc+s)) // перемеение по горизонтали >
        {
            spiral[z, z+i] = c;
            i++; c++;
        }
        i = 0;
        while(c < (dc+vc-1)+s) // перемеение по вертикали v
        {
            spiral[z+i, (d-1)] = c;
            i++; c++;
        }
        i = 0;
        while(c < ((dc*2+vc)-2)+s) // перемеение по горизонтали <
        {
            spiral[(v-1), (d-1)-i] = c;
            i++; c++;
        }
        i = 0;
        while(c < ((dc+vc)*2-3)+s) // перемеение по вертикали ^
        {
            spiral[(v-1)-i, z] = c;
            i++; c++;
        }       
        z++; s=c-1; v=v-1; d=d-1; vc=vc-2; dc=dc-2; //сужаем площадь заполнения
    }
    if(spiral.GetLength(0)==spiral.GetLength(1)&&spiral.GetLength(0)%2 == 1)
    spiral[z, z] = c; // заполнение центрального элемента нечетной матрици
}

Console.Clear();
int[,] matrix = new int [5,5];
SpiralMatrix(matrix);
PrintArray(matrix);

    