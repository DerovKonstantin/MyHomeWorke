
//---------------------------------
//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//  0, 7, 8, -2, -2 -> 2
//  1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Enter numbers using a comma (,) -> ");
int[] convertarray = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();

int count = 0;
for(int i = 0; i < convertarray.Length; i++)
{
    if(convertarray[i] > 0) count++;
}
Console.WriteLine("User entered - " + count + " - numbers greater than zero");
//----------------------------------------------------------------------------
/*
// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

float k1 = Input("Enter k1 -> ");
float b1 = Input("Enter b1 -> ");
float k2 = Input("Enter k2 -> ");
float b2 = Input("Enter b2 -> ");

float x = -(b1 - b2) / (k1 - k2);
float y = k2 * x + b2;

Console.WriteLine("Point of intersection of two lines -> х = " + x + ", y = " + y);
//---------------------------------------------------------------------------------
*/