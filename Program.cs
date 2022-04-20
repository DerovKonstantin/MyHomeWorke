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

*/
// Решение задачи №10

void SecondDigit()
{
    Console.Write("Input three digit number: ");
    int tdn = Convert.ToInt32(Console.ReadLine());
    Console.Write(tdn + " -> ");
    int ddn = tSdn / 100;
    int sdn = ddn % 10;

    Console.Write(sdn);
}

SecondDigit();

