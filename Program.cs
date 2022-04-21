/*

// Пример задачи из семинара
void ReduceNumber()
{
    int num = new Random().Next(100,999);
    Console.Write(num + " -> ");
    int num1 = num / 100;
    int num2 = num % 10;

    Console.Write(num1);
    Console.Write(num2);
}

ReduceNumber();



//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

// Решение задачи №10

void SecondDigit()
{
    Console.Write("Input three digit number: ");
    int tdn = Convert.ToInt32(Console.ReadLine());
    Console.Write(tdn + " -> ");
    int ddn = tdn / 10;
    int sdn = ddn % 10;

    Console.Write(sdn);
    Console.WriteLine( " " );
}

SecondDigit();



Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

*/

void SecondDigit(int num)

{
    if( num < 100)
    {
        Console.WriteLine( " No third digit " );
    }
    else
    {
         while (num > 1000)
    {
        num = num / 10;
        
    } 
    if (num < 1000)
        {
            num = num % 10;
        }
    Console.Write(num);
    Console.WriteLine( " " );
    }
}

Console.Write("Input three digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(num + " -> ");
SecondDigit(num);
