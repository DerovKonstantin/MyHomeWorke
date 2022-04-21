
/*
Задача 19 

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/

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
