/*
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
    Console.WriteLine();
}

//-------------------------------------------------------------------------
// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

void DescendingRowElements(int[,] inmatrix)
{
    for(int i = 0; i < inmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inmatrix.GetLength(1); j++)
        { 
            for (int c = j + 1; c < inmatrix.GetLength(1); c++)
            {
                if(inmatrix[i,c] > inmatrix[i,j])
                {
                    int temporary = inmatrix[i,j];
                    inmatrix[i,j] = inmatrix[i,c];
                    inmatrix[i,c] = temporary;
                }
            } 
        }
    }
}

Console.Clear();
int[,] matrix = new int[4, 4];
CreatMatrix(matrix);
PrintMatrix(matrix);
DescendingRowElements(matrix);
PrintMatrix(matrix);
//--------------------------------------------------------------------------

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

void FindingRowSmallestSumElements(int[,] inmatrix)
{
    int rownumber = 0;
    int minsumelements = int.MaxValue;
    
    for(int i = 0; i < inmatrix.GetLength(0); i++)
    {
        int sumrowelements = 0;
        for (int j = 0; j < inmatrix.GetLength(1); j++)
        { 
            sumrowelements += inmatrix[i,j];
        }
        if(minsumelements > sumrowelements )
        {
            minsumelements = sumrowelements;
            rownumber = i+1; // +1 для лучшего восприятия нумерации строк
        }  
    }

    Console.WriteLine("The row with the smallest sum of elements - " + rownumber);
}

Console.Clear();
int[,] matrix = new int[4, 6];
CreatMatrix(matrix);
PrintMatrix(matrix);
FindingRowSmallestSumElements(matrix);
//--------------------------------------------------------------------------------

// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

void MatrixProduct(int[,] infirstmatrix, int[,] insecondmatrix)
{
    int[,] inthirdmatrix = new int[insecondmatrix.GetLength(0), insecondmatrix.GetLength(1)];
    for(int i = 0; i < insecondmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < insecondmatrix.GetLength(1); j++)
        {
            for (int c = 0; c < infirstmatrix.GetLength(1); c++)
            {
                inthirdmatrix[i,j] += infirstmatrix[i,c] * insecondmatrix[c,j];
                
            }
            Console.Write(inthirdmatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] firstmatrix = new int[3, 3];
int[,] secondmatrix = new int[3, 3];
CreatMatrix(firstmatrix);
CreatMatrix(secondmatrix);
PrintMatrix(firstmatrix);
PrintMatrix(secondmatrix);
MatrixProduct(firstmatrix, secondmatrix);
//--------------------------------------------------------------------------

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

void Creat3Dmatrix(int[,,] creat3dmatrix)
{
    int size3dmatrix = creat3dmatrix.GetLength(0) * creat3dmatrix.GetLength(1) * creat3dmatrix.GetLength(2);
    int[] librarynumbers =  new int[size3dmatrix];
    librarynumbers[0] = new Random().Next(10, 100);
    int l = 1;

    while (l < librarynumbers.Length)
    {
        int count = 0;
        int generatedelement = new Random().Next(10, 100);
        for (int s = 0; s < librarynumbers.Length; s++)
        {
            if (generatedelement == librarynumbers[s])
            {
                count++;
            }
        }
        if (count == 0)
        { 
            librarynumbers[l] = generatedelement; 
            l++;
        }
    }

    l = 0;

    for(int i = 0; i < creat3dmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < creat3dmatrix.GetLength(1); j++)
        {
            for (int c = 0; c < creat3dmatrix.GetLength(2); c++)
            {
                creat3dmatrix[i, j, c] = librarynumbers[l];
                l++;    
            }        
        }
    }
}

void Print3Dmatrix(int[,,] print3dmatrix) // просто печать 3Д матрици
{
    for(int i = 0; i < print3dmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < print3dmatrix.GetLength(1); j++)
        {
            for (int c = 0; c < print3dmatrix.GetLength(1); c++)
            {
                Console.Write(print3dmatrix[i, j, c] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void Print3DMatrixShiftUp(int[,,] print3dmatrix) // печать 3Д матрици со смещением вверх в право
{
    for(int j = 0; j < print3dmatrix.GetLength(1); j++)
    {
        for (int i = print3dmatrix.GetLength(0)-1; i >= 0; i--)
        {
            for (int c = 0; c < print3dmatrix.GetLength(2); c++)
            { 
                if(c == 0)
                {
                    int count = i;
                    while(count > 0)
                    {
                        Console.Write("  ");
                        count--;
                    }
                    Console.Write(print3dmatrix[i, j, c] + "[" + i + "," + j + "," + c + "]     ");
                }
                else
                {
                    Console.Write(print3dmatrix[i, j, c] + "[" + i + "," + j + "," + c + "]     ");
                }  
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Print3DMatrixShiftDown(int[,,] print3dmatrix) // печать 3Д матрици со смещением вниз в право
{
    for(int j = 0; j < print3dmatrix.GetLength(1); j++)
    {
        for (int i = 0; i < print3dmatrix.GetLength(0); i++)
        {
            for (int c = 0; c < print3dmatrix.GetLength(2); c++)
            {
                if(c == 0)
                {
                    int count = i;
                    while(count > 0)
                    {
                        Console.Write("  ");
                        count--;
                    }
                    Console.Write(print3dmatrix[i, j, c] + "[" + i + "," + j + "," + c + "]     ");
                }
                else
                    {
                        Console.Write(print3dmatrix[i, j, c] + "[" + i + "," + j + "," + c + "]     ");
                    }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
int[,,] threedmatrix = new int[3, 3, 3];
Creat3Dmatrix(threedmatrix);
Print3Dmatrix(threedmatrix); // просто печать 3Д матрици
Print3DMatrixShiftUp(threedmatrix); // печать 3Д матрици со смещением вверх в право
Print3DMatrixShiftDown(threedmatrix); // печать 3Д матрици со смещением вниз в право
//----------------------------------------------------------------------------------

//  Задача 62: Заполните спирально массив 4 на 4.

void  PrintSpiralMatrix(int[,] spiral )
{
    for (int i = 0; i < spiral.GetLength(0); i++)
    {
        for (int j = 0; j < spiral.GetLength(1); j++)
        {
            if(spiral[i, j] < 10) Console.Write("   " + spiral[i, j]);
            if(spiral[i, j] >= 10 && spiral[i, j] < 100) Console.Write("  " + spiral[i, j]);
            if(spiral[i, j] >= 100 && spiral[i, j] < 1000) Console.Write(" " + spiral[i, j]);
            //Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void CreatSpiralMatrix(int[,] spiral)
{
    int reductionsizematrix  = 0; // изменение матрици на размер "totalelementcount" после 1 прохода
    int z = 0; // нулевая точька
    int count = 0; // щетчик одного перемещения, лево-право, вверх-низ
    int totalelementcount = 1; // общий щетчик
    int elementsheight = spiral.GetLength(0); // колличество знаков по высоте
    int elementslength = spiral.GetLength(1); // колличество знаков по длинне
    int height = spiral.GetLength(0); // высота
    int length = spiral.GetLength(1); // длинна
    while (totalelementcount < spiral.GetLength(0) * spiral.GetLength(1)) // общее колличество циклов
    {
        count = 0;
        while(totalelementcount < (elementslength + reductionsizematrix)) // перемеение по горизонтали >
        {
            spiral[z, z + count] = totalelementcount;
            count++; totalelementcount++;
        }
        count = 0;
        while(totalelementcount < (elementslength + elementsheight -1) + reductionsizematrix) // перемеение по вертикали v
        {
            spiral[z + count, (length -1)] = totalelementcount;
            count++; totalelementcount++;
        }
        count = 0;
        while(totalelementcount < ((elementslength * 2 + elementsheight) -2) + reductionsizematrix) // перемеение по горизонтали <
        {
            spiral[(height -1), (length -1) - count] = totalelementcount;
            count++; totalelementcount++;
        }
        count = 0;
        while(totalelementcount < ((elementslength + elementsheight) * 2 -3) + reductionsizematrix) // перемеение по вертикали ^
        {
            spiral[(height - 1) - count, z] = totalelementcount;
            count++; totalelementcount++;
        }       
        z++; reductionsizematrix = totalelementcount -1; height = height -1; length = length -1; //сужаем площадь заполнения
        elementsheight = elementsheight -2; elementslength = elementslength -2; //сужаем площадь заполнения
    }
    if(spiral.GetLength(0) == spiral.GetLength(1) && spiral.GetLength(0) % 2 == 1)
    spiral[z, z] = totalelementcount; // заполнение центрального элемента нечетной матрици
}

Console.Clear();
int[,] matrix = new int [5,5];
CreatSpiralMatrix(matrix);
PrintSpiralMatrix(matrix);
//-----------------------------------------------------------------------------
*/
// СЕМИНАР №8
//=============================================================================

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
/*
/--------------------------------------------------------------------------------------------
// Задача 57 Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информцию о том, сколько раз встречается елемент входных данных.

void RepeatElementCounter(int[,] inmatrix)
{
    int minelement = inmatrix[0,0];
    int maxelement = inmatrix[0,0];
    for (int i = 0;i < inmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inmatrix.GetLength(1); j++)
        {
            if(minelement > inmatrix[i, j]) minelement = inmatrix[i, j];
            if(maxelement < inmatrix[i, j]) maxelement = inmatrix[i, j];
        }
    }
    Console.WriteLine("Minimum element " + minelement + " and maximum element " + maxelement);
    
    while (minelement < maxelement)
    {
        int count = 0;
        for (int i = 0;i < inmatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inmatrix.GetLength(1); j++)
            {
                if(minelement == inmatrix[i, j]) count++;
            }
        }
        if(count > 0)
        {
            Console.WriteLine( minelement + " meets " + count + " times");
        }
        minelement++;  
    }
}

Console.Clear();
int[,] matrix = new int[4, 4];
CreatMatrix(matrix);
PrintMatrix(matrix);
RepeatElementCounter(matrix);
//-----------------------------------------
*/

// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.

int[,] UmenscenieMatrix(int[,] inmatrix)
{
    int minelement = inmatrix[0,0];
    int minstring = 0;
    int mincolumn = 0;

    for (int i = 0;i < inmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inmatrix.GetLength(1); j++)
        {
            if(minelement > inmatrix[i, j])
            {
                minelement = inmatrix[i, j];
                minstring = i;
                mincolumn = j;
            }
        }
    }
    Console.WriteLine("минимальный элемент - " + minelement + " строка - " + minstring +
    "; столбец - " + mincolumn);

    int[,] modifiedmatrix = new int[inmatrix.GetLength(0)-1, inmatrix.GetLength(1)-1];
    int icountmatrix = 0; // inmatrix
    int jcountmatrix = 0; // inmatrix
    int icountmodmatrix = 0; // modifiedmatrix
    int jcountmodmatrix = 0; // modifiedmatrix

    while (icountmatrix < inmatrix.GetLength(0))
    {
        if(icountmatrix == minstring)
        {
            icountmatrix++;
        }
        while (jcountmatrix < inmatrix.GetLength(1))
        {
            if(jcountmatrix == mincolumn)
            {
                jcountmatrix++;
            }
            modifiedmatrix[icountmodmatrix, jcountmodmatrix] = inmatrix[icountmatrix, jcountmatrix];
            jcountmatrix++; jcountmodmatrix++;
        }
        icountmatrix++; icountmodmatrix++; jcountmatrix = 0; jcountmodmatrix = 0;
    }
    return modifiedmatrix;
}

Console.Clear();
int[,] matrix = new int[4, 4];
CreatMatrix(matrix);
PrintMatrix(matrix);
PrintMatrix(UmenscenieMatrix(matrix));



