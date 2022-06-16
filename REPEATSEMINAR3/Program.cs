int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

/*
//-------------------------------------------------------------------------------------------------------------
//  Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//  14212 -> нет
//  23432 -> да
//  12821 -> да

int DigitInANumber(int dozens, int number)
{
    number = (number/dozens) %10;
    return number;
}
void PalindromeDetekted(int number)
{
    int digit5 = DigitInANumber(1, number);
    int digit4 = DigitInANumber(10, number);
    int digit3 = DigitInANumber(100, number);
    int digit2 = DigitInANumber(1000, number);
    int digit1 = DigitInANumber(10000, number);

    if(digit1 == digit5 && digit2 == digit4)
        Console.WriteLine( number +  " -> The number is a PALINDROME " );
    else
        Console.WriteLine( number +  " -> Number is NOT a palindrome " );
}

Console.Clear();
int num = Input("Input five-digit number: ");

if(num < 100000 && num > 10000)
    PalindromeDetekted(num);
else
    Console.WriteLine( "Wrong number entered - Input five-digit number " );
//-------------------------------------------------------------------------

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Points(int coordinatea, int coordinateb)
{
    int points = (coordinatea - coordinateb) * (coordinatea - coordinateb);
    return points;
}

double LineSegment (int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt( Points(xa,xb) + Points(ya,yb) + Points(za,zb) );
}

int xa = Input("Enter the coordinate of the first point: ");
int ya = Input("Enter the coordinate of the second point: ");
int za = Input("Enter the coordinate of the third point: ");
int xb = Input("Enter the coordinate of the fourth point: ");
int yb = Input("Enter the coordinate of the fifth point: ");
int zb = Input("Enter the coordinate of the sixth point: ");

Console.Clear();
string result = string.Format("{0:f}", LineSegment (xa, ya, za, xb, yb, zb));
Console.WriteLine(result);
//---------------------------------------------------------------------------

//  Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//  3 -> 1, 8, 27.
//  5 -> 1, 8, 27, 64, 125

int Cub(int number)
{
    number = number * number * number;
    return number;
}

void NumCub(int N)
{
    int count = 1;
    while(count < N)
    {
        Console.Write(Cub(count) + ", ");
        count++;
    }
    Console.Write(Cub(count) + " ");
}

Console.Clear();
int N = Input("Input number (N): ");
Console.Write(N + " -> ");
NumCub(N);
Console.WriteLine();
//-------------------------------------
*/