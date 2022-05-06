
/*
Пример с урока №3 по поиску максимального элемента

Console.Clear();

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

//  Переписали строку
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

//  Блок поиска максимального элемента
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++ )
        {
            if(array[j] < array[minPosition]) minPosition = j;
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

----------------------------------------------------------------------------
//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//  0, 7, 8, -2, -2 -> 2

//  1, -7, 567, 89, 223-> 3

//  Решение


Console.Clear();

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void NumberOfNumbersGreaterThan0(int[] array)
{
    int numofnum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) numofnum++;
    }
    Console.Write("Number of Numbers greater than 0 is (Колличество чисел больше 0) = " + numofnum);
    Console.WriteLine();
}

PrintArray(arr);
NumberOfNumbersGreaterThan0(arr);



//  Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//  45 -> 101101

//  3 -> 11

//  2 -> 10

//  Решение



Console.Clear();
void ConDecToBinary (int tennum)
{
    int binnum = 0;
    int proxynum = 0;
    if(tennum == 0) binnum = 0;
    if(tennum == 1) binnum = 1;
    if(tennum == 2) binnum = 10;
    if(tennum == 3) binnum = 11;
    if(tennum == 4) binnum = 100;
    if(tennum == 5) binnum = 101;
    if(tennum == 6) binnum = 110;
    if(tennum == 7) binnum = 111;
    if(tennum == 8) binnum = 1000;
    if(tennum == 9) binnum = 1001;
    if(tennum == 10) binnum = 1010;
    if(tennum > 0)
    
    {
        for(int i = 0; proxynum < cdtbnum ; i++)
        {
            proxynum = proxynum + 1;
            binnum = binnum + 1;
            if(proxynum < cdtbnum)
            {
                proxynum = proxynum + 1;
                binnum = (binnum - 1) * 10;
            }
        }    
        Console.WriteLine(" is  " + binnum );
    }
    
}

Console.Write("Input number: ");
int cdtbnum = Convert.ToInt32(Console.ReadLine());
ConDecToBinary (cdtbnum);

*/

Console.Clear();
void ConDecToBinary (int tennum)
{
    
    
    {
        int count = 0;
        for(int i = 0; 0 < tennum ; i++)
        {
            tennum = tennum / 2;
            count = count +1;
            
            Console.Write(" is  " + count );
            Console.WriteLine(" is  " + tennum );
        }    
        
    }
    
}

Console.Write("Input number: ");
int tennum = Convert.ToInt32(Console.ReadLine());
ConDecToBinary (tennum);