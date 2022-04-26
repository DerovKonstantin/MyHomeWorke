
/*
// Пример из семинра (генератор рандомных чисел)

int[] CrreateRandomArray(int size, int min, int max)

{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}

// Вывод массива

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

//Сумма положительных и отрицательных элементов массива

void FindeSumOfElements (int[] array)
{
    int plussum = 0;
    int minussum = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        // sum = sum + i;
        // sum += i;
        if(array[i] > 0)
            plussum += array[i];
        else
            minussum += array[i];
    }
    Console.WriteLine("Sum of positive elementa is " + plussum);
    Console.WriteLine("Sum of negative elementa is " + minussum);
}

int[] myArray = CrreateRandomArray(12,-9,9);
ShowArray(myArray);
FindeSumOfElements(myArray);





// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Решение задачи 34

int[] CrreateRandomArray(int size, int min, int max)

{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void FindeEvenNumbers (int[] array)
{
    int ENum = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            // sum = sum + i;
            // sum += i;
            if(array[i] %2 == 0)
                ENum = ENum + 1;
            else
                ENum = ENum + 0;
        }
        else
                ENum = ENum + 0;
        
    }
    Console.WriteLine("The number of even numbers in the array " + ENum);
}

int[] myArray = CrreateRandomArray(3,0,10);
ShowArray(myArray);
FindeEvenNumbers (myArray);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Решение задачи 36

int[] CrreateRandomArray(int size, int min, int max)

{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void SumElementsOddPositions (int[] array)
{
    int SEONum = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
            SEONum = SEONum + array[i];
        else
            SEONum = SEONum + 0;
    }
    Console.WriteLine("Sum of elements of odd positions is " + SEONum);
}

int[] myArray = CrreateRandomArray(20,0,10);
ShowArray(myArray);
SumElementsOddPositions(myArray);

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// решение задачи №38

double [] CrreateRandomArray(int size, double min, double max)

{
    double[] array = new double [size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble()* (max - min) + min;
    }

    return array;
}

void ShowArray(double[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void DiffMaxMinElements (double[] array)
{
    double difmaxnum = 0;
    double difminnum = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > difmaxnum)
            difmaxnum = array[i];
        if(array[i] < difminnum)
            difminnum = array[i];
    }
    double difmaxminnum = difmaxnum - difminnum;

    Console.WriteLine("Maximum element is " + difmaxnum);
    Console.WriteLine("Minimum element is " + difminnum);
    Console.WriteLine("Difference between maximum and minimum is " + difmaxminnum);
}

double[] myArray = CrreateRandomArray(10, -10, 10);
ShowArray(myArray);
DiffMaxMinElements(myArray);
