
/*
//Задача 19 

    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    14212 -> нет

    12821 -> да

    23432 -> да

// Решение задачи 19

void PalindromeDetekted(int num)
{
    int num1 = num / 10000;
    int num2 = (num / 1000)%10;
    int num3 = (num % 100)/10;
    int num4 = num % 10;
    int numpal1 = (num2 * 10) + num1;
    int numpal2 = (num3 * 10) + num4;

    if(numpal1 == numpal2)
        Console.Write( " The number is a PALINDROME " );
    else
        Console.Write( " Number is NOT a palindrome " );
    
    Console.WriteLine( " " );
}

Console.Write("Input five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(num + " -> ");
if(num < 100000 && num > 10000)
    PalindromeDetekted(num);
else
    Console.Write( " Wrong number entered - Input five-digit number " );
    Console.WriteLine( " " );



//Задача 21

    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    A (3,6,8); B (2,1,-7), -> 15.84

    A (7,-5, 0); B (1,-1,9) -> 11.53

    */

Console.Clear();
double LineSegment (double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt((xa-xb)*(xa-xb) + (ya-yb)*(ya-yb) + (za-zb)*(za-zb));
}

Console.WriteLine(" Enter the coordinate of the first point: ");
double xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter the coordinate of the second point: ");
double ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter the coordinate of the third point: ");
double za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter the coordinate of the fourth point: ");
double xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter the coordinate of the fifth point: ");
double yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter the coordinate of the sixth point: ");
double zb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(LineSegment (xa, ya, za, xb, yb, zb));
