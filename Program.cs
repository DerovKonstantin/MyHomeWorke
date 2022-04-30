
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

/*

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



//  Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//  3, 5 -> 243 (3⁵)

//  2, 4 -> 16

// Решение

*/

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