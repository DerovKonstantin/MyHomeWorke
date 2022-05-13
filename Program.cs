/*
//------------------------------------------------------------------------------------------
//  Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//  45 -> 101101
//  3 -> 11
//  2 -> 10

Console.Clear();
Console.Write("Введите десятичное число (Enter a decimal number) - ");
int tennum = Convert.ToInt32(Console.ReadLine()); 
int binnum = 0; //  а - остаток после % деления из которого формируется число в даоичной системе исчесления
int i = 0; 
int saiz = 0; // s - размер прредпологаемого массива
int snum = tennum;
while(snum >= 1)
{
    saiz++;
    snum = snum / 2;
}
int[] b = new int[saiz]; // развернутый массив
while(tennum >= 1)
{
    binnum = tennum % 2;
    b[i] = binnum;
    i++;
    tennum = tennum / 2;
}

for(i = (b.Length - 1); i >= 0; i--)
{
    Console.Write(b[i]);
}
Console.WriteLine();

//------------------------------------------------------------------------------------------------------------

//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//  0, 7, 8, -2, -2 -> 2
//  1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел (Enter numbers separated by spaces): - ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int count = 0;

for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("пользователь ввёл ( user entered ) - " + count + " - чисел больше нуля (numbers greater than zero)");

//----------------------------------------------------------------------------------------------------------------------

*/
//  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.Write("Введите k1(Enter k1): ");
float k1 = Convert.ToInt32(Console.ReadLine()); // var k1 = Convert.ToDoble(Console.ReadLine());
Console.Write("Введите b1(Enter b1): ");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2(Enter k2): ");
float k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2(Enter b2): ");
float b2 = Convert.ToInt32(Console.ReadLine());

float x = -(b1 - b2) / (k1 - k2);
float y = k2 * x + b2;

Console.Write(" Точка пересечения двух прямых (Point of intersection of two lines): х = " + x + " и y = " );
Console.WriteLine(y);