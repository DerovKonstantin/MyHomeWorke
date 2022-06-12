int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
int reducingToXDigitNumber(int x, int num)
{
    while(num > x) num /= 10;
    return num;
    
}
/*
//-------------------------------------------------------------------------------------------------------------
//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//  456 -> 5
//  782 -> 8
//  918 -> 1

void SecondDigit()
{
    Console.Clear();
    int twodigitnumber = Input("Input three digit number: ");
    if(twodigitnumber >= 100 && twodigitnumber < 1000) 
    {
        twodigitnumber = reducingToXDigitNumber(100, twodigitnumber);
        Console.Write("The second digit will be ");
        int seconddigit = twodigitnumber % 10;
        Console.WriteLine(seconddigit);
    }
    else Console.WriteLine("The number you enter must be three digits");
}
SecondDigit();
//-----------------------------------------------------------------------
//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  645 -> 5
//  78 -> третьей цифры нет
//  32679 -> 6

void SecondDigit()
{
    Console.Clear();
    int inputnumber = Input("Input number: ");
    if(inputnumber < 100) Console.WriteLine("No third digit");
    if(inputnumber >= 100) 
    {
        inputnumber = reducingToXDigitNumber(1000, inputnumber);
        Console.Write("The third digit will be ");
        int thirddigit = inputnumber % 10;
        Console.WriteLine(thirddigit);
    }
}
SecondDigit();
//--------------------------------------------------------------
//  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//  6 -> да
//  7 -> да
//  1 -> нет

void NumberOfWeekday(int day)
{
    Console.Clear();
    if(day < 1 || day > 7) Console.WriteLine( "Incorrect number of day " );
    else if(day == 6 || day == 7) Console.WriteLine(day + " -> Yes ");
    else if(day >= 1 || day <= 5) Console.WriteLine(day + " -> No ");
}
int weekday = Input("Input number of weekday: ");
NumberOfWeekday(weekday);
//-------------------------------------------------------------------------
// Доп. задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

void NumberTheSquareOfAnother(int firstnum, int secondnum)
{
    if(firstnum == secondnum * secondnum || secondnum == firstnum * firstnum) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}
int firstnum = Input("Input first number: ");
int secondnum = Input("Input second number: ");
NumberTheSquareOfAnother(firstnum, secondnum);
*/