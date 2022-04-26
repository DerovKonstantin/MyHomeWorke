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



/*

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

*/


